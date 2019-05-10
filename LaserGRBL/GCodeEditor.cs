using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaserGRBL
{
    public partial class GCodeEditor : Form
    {
        public GrblCore Core { get; private set; }

        private List<GrblCommand> backup;

        private GCodeTransform.TransformParam lastTransformParam = new GCodeTransform.TransformParam();

        #region FCTB

        // highlight code in editor
        private Style StyleComment = new TextStyle(Brushes.Gray, null, FontStyle.Italic);
        private Style StyleGWord = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        private Style StyleMWord = new TextStyle(Brushes.SaddleBrown, null, FontStyle.Regular);
        private Style StyleFWord = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        private Style StyleSWord = new TextStyle(Brushes.OrangeRed, null, FontStyle.Regular);
        private Style StyleTool = new TextStyle(Brushes.Black, null, FontStyle.Regular);
        private Style StyleLineN = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
        private Style StyleXAxis = new TextStyle(Brushes.Green, null, FontStyle.Bold);
        private Style StyleYAxis = new TextStyle(Brushes.BlueViolet, null, FontStyle.Bold);
        private Style StyleZAxis = new TextStyle(Brushes.Red, null, FontStyle.Bold);
        private Style StyleAAxis = new TextStyle(Brushes.DarkCyan, null, FontStyle.Bold);

        private void fCTBCode_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
#if (debuginfo)
            log.Add("MainFormFCTB event fCTBCode_TextChanged");
#endif
            e.ChangedRange.ClearStyle(StyleComment);
            e.ChangedRange.SetStyle(StyleComment, "(\\(.*\\))", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleGWord, "(G\\d{1,2})", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleMWord, "(M\\d{1,2})", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleFWord, "(F\\d+)", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleSWord, "(S\\d+)", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleLineN, "(N\\d+)", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleTool, "(T\\d{1,2})", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleXAxis, "[XIxi]{1}-?\\d+(.\\d+)?", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleYAxis, "[YJyj]{1}-?\\d+(.\\d+)?", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleZAxis, "[Zz]{1}-?\\d+(.\\d+)?", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetStyle(StyleAAxis, "[AaBbCcUuVvWw]{1}-?\\d+(.\\d+)?", System.Text.RegularExpressions.RegexOptions.Compiled);
            e.ChangedRange.SetFoldingMarkers("\\(<PD", "\\(</PD");
        }

        private void fCTB_CheckUnknownCode()
        {
            string curLine;
            string allowed = "ABCNGMFIJKLNPRSTUVWXYZOPLabcngmfijklnprstuvwxyzopl ";
            string number = " +-.0123456789";
            string cmt = "(;";
            string message = "";
            for (int i = 0; i < fCTBCode.LinesCount; i++)
            {
                curLine = fCTBCode.Lines[i].Trim();
                if ((curLine.Length > 0) && (cmt.IndexOf(curLine[0]) >= 0))             // if comment, nothing to do
                {
                    if (curLine[0] == '(')
                    {
                        if (curLine.IndexOf(')') < 0)                               // if last ')' is missing
                        {
                            fCTBCode.Selection = fCTBCode.GetLine(i);
                            fCTBCode.SelectedText = curLine + " <- unknown command)";
                            message += "Line " + i.ToString() + " : " + curLine + "\r\n";
                        }
                    }
                }
                else if ((curLine.Length > 0) && (allowed.IndexOf(curLine[0]) < 0))     // if 1st char is unknown - no gcode
                {
                    fCTBCode.Selection = fCTBCode.GetLine(i);
                    fCTBCode.SelectedText = "(" + curLine + " <- unknown command)";
                    message += "Line " + i.ToString() + " : " + curLine + "\r\n";
                }
                else if ((curLine.Length > 1) && (number.IndexOf(curLine[1]) < 0))  // if 1st known but 2nd not part of number
                {
                    fCTBCode.Selection = fCTBCode.GetLine(i);
                    fCTBCode.SelectedText = "(" + curLine + " <- unknown command)";
                    message += "Line " + i.ToString() + " : " + curLine + "\r\n";
                }
            }
            if (message.Length > 0)
                MessageBox.Show("Fixed some unknown GCode:\r\n" + message);
        }

        // mark clicked line in editor
        private int fCTBCodeClickedLineNow = 0;
        private int fCTBCodeClickedLineLast = 0;
        private void fCTBCode_Click(object sender, EventArgs e)
        {
            fCTBCodeClickedLineNow = fCTBCode.Selection.ToLine;
            fCTBCodeMarkLine();
            //           MessageBox.Show(visuGCode.getLineInfo(fCTBCodeClickedLineNow));
            //            fCTBCode.t  (visuGCode.getLineInfo(fCTBCodeClickedLineNow));
        }
        private void fCTBCode_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if ((key == 38) && (fCTBCodeClickedLineNow > 0))
            {
                fCTBCodeClickedLineNow -= 1;
                fCTBCodeMarkLine();
            }
            if ((key == 40) && (fCTBCodeClickedLineNow < (fCTBCode.Lines.Count - 1)))
            {
                fCTBCodeClickedLineNow += 1;
                fCTBCodeMarkLine();
            }
        }
        private void fCTBCodeMarkLine()
        {
#if (debuginfo)
            log.Add("MainFormFCTB fCTBCodeMarkLine() now: "+ fCTBCodeClickedLineNow.ToString() + " last: "+ fCTBCodeClickedLineLast.ToString());
#endif
            if ((fCTBCodeClickedLineNow <= fCTBCode.LinesCount) && (fCTBCodeClickedLineNow >= 0))
            {
                if (fCTBCodeClickedLineNow != fCTBCodeClickedLineLast)
                {
                    fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                    fCTBCode.BookmarkLine(fCTBCodeClickedLineNow);
                    fCTBCodeClickedLineLast = fCTBCodeClickedLineNow;
                    // Set marker in drawing
                    //visuGCode.setPosMarkerLine(fCTBCodeClickedLineNow, !isStreaming);
                    //pictureBox1.Invalidate(); // avoid too much events
                    //toolStrip_tb_StreamLine.Text = fCTBCodeClickedLineNow.ToString();
                }
            }
        }

        // context Menu on fastColoredTextBox
        private void cmsCode_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "cmsCodeSelect")
                fCTBCode.SelectAll();
            else if (e.ClickedItem.Name == "cmsCodeCopy")
            {
                if (fCTBCode.SelectedText.Length > 0)
                    fCTBCode.Copy();
            }
            else if (e.ClickedItem.Name == "cmsCodePaste")
                fCTBCode.Paste();
            else if (e.ClickedItem.Name == "cmsCodeSendLine")
            {
                MessageBox.Show("Under construction");
                //    int clickedLine = fCTBCode.Selection.ToLine;
                //    sendCommand(fCTBCode.Lines[clickedLine], false);
            }
            else if (e.ClickedItem.Name == "cmsCommentOut")
                fCTB_CheckUnknownCode();
            else if (e.ClickedItem.Name == "cmsUpdate2DView")
            {
                MessageBox.Show("Under construction");
                //    newCodeEnd();
            }
            else if (e.ClickedItem.Name == "cmsReplaceDialog")
                fCTBCode.ShowReplaceDialog();
            else if (e.ClickedItem.Name == "cmsFindDialog")
                fCTBCode.ShowFindDialog();
            else if (e.ClickedItem.Name == "cmsEditorHotkeys")
            {
                //showMessageForm(Properties.Resources.fctb_hotkeys);
                MessageBox.Show("Under construction");
            }
        }

        private void showMessageForm(string text)
        {
            MessageBox.Show(text, "Hotkeys");
        }

        #endregion

        private GCodeEditor()
        {
            InitializeComponent();
        }

        public GCodeEditor(GrblCore c) : this()
        {
            Core = c;

            backup = Core.LoadedFile.Select(cmd => new GrblCommand(cmd.Command)).ToList();

            loadGCodeToEditor();
        }

        private void loadGCodeToEditor(IEnumerable<GrblCommand> list = null)
        {
            StringBuilder sb = new StringBuilder();
            if (list == null)
                list = Core.LoadedFile;
            foreach (GrblCommand cmd in list)
            {
                sb.Append(cmd.Command + "\r\n");
            }

            fCTBCode.Text = sb.ToString();
        }

        private IEnumerable<GrblCommand> CompileCode()
        {
            // comment unknown code
            fCTB_CheckUnknownCode();
            // compile line by line            
            var lines = fCTBCode.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var listGcode = lines.Select(l => new GrblCommand(l));
            return listGcode;
        }

        internal void SaveCode()
        {
            var list = CompileCode();
            Core.LoadedFile.LoadListGcode(list, false);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            //restore from backup
            Core.LoadedFile.LoadListGcode(backup, false);
            //load to editor 
            loadGCodeToEditor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCode();
        }

        private void btn_transform_Click(object sender, EventArgs e)
        {
            var form = new GCodeTransform(Core, CompileCode().ToList());
            form.TransParam = lastTransformParam;

            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //save transform
                //lastTransformParam = form.TransParam;
                //doTransform(lastTransformParam);
                // apply to editor
                if (form.Result != null)
                    loadGCodeToEditor(form.Result);
            }
        }


    }
}
