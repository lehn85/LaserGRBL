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
    public partial class GCodeTransform : Form
    {
        public class TransformParam
        {
            public double BaseX { get; set; } = 0;
            public double BaseY { get; set; } = 0;
            public double DX { get; set; } = 0;
            public double DY { get; set; } = 0;
            public double ScaleX { get; set; } = 1.0;
            public double ScaleY { get; set; } = 1.0;
            public double Angle { get; set; } = 0;
            public bool LockRatio { get; set; } = true;

            //public TransformParam()
            //{

            //}

            //public TransformParam(TransformParam copy)
            //{
            //    BaseX = copy.BaseX;
            //    BaseY = copy.BaseY;
            //    DX = copy.DX;
            //    DY = copy.DY;
            //    ScaleX = copy.ScaleX;
            //    ScaleY = copy.ScaleY;
            //    Angle = copy.Angle;
            //    LockRatio = copy.LockRatio;
            //}

            //public override bool Equals(object obj)
            //{
            //    var p = obj as TransformParam;
            //    if (p == null)
            //        return false;

            //    return BaseX == p.BaseX &&
            //        BaseY == p.BaseY &&
            //        DX == p.DX &&
            //        DY == p.DY &&
            //        ScaleX == p.ScaleX &&
            //        ScaleY == p.ScaleY &&
            //        Angle == p.Angle &&
            //        LockRatio == p.LockRatio;
            //}
        }

        public TransformParam TransParam { get; set; }

        private GrblCore Core;
        private List<GrblCommand> originList;
        public List<GrblCommand> Result { get; private set; }

        private bool modifiedCore = false;

        public GCodeTransform(GrblCore core, List<GrblCommand> origin)
        {
            InitializeComponent();

            Core = core;
            originList = origin;
        }

        private void GCodeTransform_Load(object sender, EventArgs e)
        {
            if (TransParam == null)
            {
                TransParam = new TransformParam();
            }

            transformParamBindingSource.DataSource = TransParam;
        }

        private void GCodeTransform_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //TODO: apply transformation only if needed (preview click already produce result)
                doTransform();
            }
            else
            {
                //revert
                if (modifiedCore)
                    Core.LoadedFile.LoadListGcode(originList, false);
                Result = null;
            }
        }

        private void chBox_lockRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_lockRatio.Checked)
            {
                nud_scaleY.Value = nud_scaleX.Value;
                TransParam.ScaleY = Convert.ToDouble(nud_scaleX.Value);
            }

            nud_scaleY.Enabled = !chBox_lockRatio.Checked;
        }

        private void nud_scaleX_ValueChanged(object sender, EventArgs e)
        {
            if (chBox_lockRatio.Checked)
            {
                nud_scaleY.Value = nud_scaleX.Value;
                TransParam.ScaleY = Convert.ToDouble(nud_scaleX.Value);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            TransParam = new TransformParam();
            transformParamBindingSource.DataSource = TransParam;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            doTransform();
        }

        private void doTransform()
        {
            double curX = 0;
            double curY = 0;

            var cost = Math.Cos(Math.PI * TransParam.Angle / 180);
            var sint = Math.Sin(Math.PI * TransParam.Angle / 180);

            var list = new List<GrblCommand>();

            foreach (var cmd in originList)
            {                
                cmd.BuildHelper();
                var elements = cmd.GetElements();

                if (cmd.IsLinearMovement)
                {
                    //get x,y
                    double x = cmd.X != null ? Convert.ToDouble(cmd.X.Number) : curX;
                    double y = cmd.Y != null ? Convert.ToDouble(cmd.Y.Number) : curY;
                    // update current x,y
                    curX = x;
                    curY = y;
                    //transform x,y
                    // scale
                    var x1 = (x - TransParam.BaseX) * TransParam.ScaleX + TransParam.BaseX;
                    var y1 = (y - TransParam.BaseY) * TransParam.ScaleY + TransParam.BaseY;
                    // rotate                    
                    var x2 = x1 * cost - y1 * sint;
                    var y2 = y1 * cost + x1 * sint;
                    // translate
                    var x3 = x2 + TransParam.DX;
                    var y3 = y2 + TransParam.DY;

                                        
                    elements['X'] = new GrblCommand.Element('X', Math.Round(Convert.ToDecimal(x3), 4));
                    elements['Y'] = new GrblCommand.Element('Y', Math.Round(Convert.ToDecimal(y3), 4));

                    // apply change
                    list.Add(new GrblCommand(elements.Values));
                }
                else if (cmd.IsArcMovement)
                {

                }
                else
                {
                    list.Add(new GrblCommand(cmd.Command));
                }

                cmd.DeleteHelper();
            }

            Core.LoadedFile.LoadListGcode(list, false);
            modifiedCore = true;
            Result = list;
        }
    }
}
