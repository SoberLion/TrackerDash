using System.Drawing;
using System.Windows.Forms;

namespace TrackerHelper
{
    public partial class customProgressBar : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        private int _progressValue;
        private Color _progressColor = Color.Red;
        private string _progressText;

        public customProgressBar()
        {
            InitializeComponent();
        }

        public int ProgressValue
        {
            get { return _progressValue; }
            set
            {
                if (value > 100)
                    _progressValue = 100;
                else if (value < 0)
                    _progressValue = 0;
                else
                    _progressValue = value;
                Invalidate();
            }
        }

        public Color ProgressColor
        {
            get { return _progressColor; }
            set
            {
                _progressColor = value;
                Invalidate();
            }
        }

        public string ProgressText
        {
            get { return _progressText; }
            set
            {
                _progressText = value;
                Invalidate();
            }
        }

        private void customProgressBar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(ProgressColor);
            Rectangle r = new Rectangle(0, 0, Width * ProgressValue / 100, Height);
            e.Graphics.DrawRectangle(pen, r);
            e.Graphics.FillRectangle(new SolidBrush(ProgressColor), r);

            StringFormat ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(ProgressText, Font, new SolidBrush(ForeColor), ClientRectangle, ft);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // customProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "customProgressBar";
            this.Size = new System.Drawing.Size(146, 16);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.customProgressBar_Paint);
            this.ResumeLayout(false);

        }

    }
}
