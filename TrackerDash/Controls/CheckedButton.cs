using System;
using System.Windows.Forms;

namespace TrackerHelper
{
    public partial class CheckedButton : Button
    {
        public delegate void Checked(object sender, EventArgs e);
        public event Checked CheckedChange;
        private bool _Checked = false;
        
        public bool Check
        {
            get { return _Checked; }
            set
            {
                if (value != _Checked)
                {
                    CheckedChange?.Invoke(this, EventArgs.Empty);
                    _Checked = value;
                }
            }
        }

        public CheckedButton()
        {
            InitializeComponent();
        }
    }
}
