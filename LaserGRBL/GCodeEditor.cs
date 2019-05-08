using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaserGRBL
{
    public partial class GCodeEditor : Form
    {
        public GrblCore Core { get; private set; }

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



        private GCodeEditor()
        {
            InitializeComponent();
        }

        public GCodeEditor(GrblCore c) : this()
        {
            Core = c;

            foreach(GrblCommand cmd in Core.LoadedFile)
            {
                fastColoredTextBox1.AppendText(cmd.Command + "\r\n");
            }

        }
    }
}
