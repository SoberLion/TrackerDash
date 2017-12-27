using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper;

namespace TrackerDash.Controls
{
    class Dashboard : UserControl
    {
        protected DashboardPreset _preset = new DashboardPreset();
        static string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        protected int[] _userIdArray = new int[] { 1 };
        protected int[] _statusIdArray = new int[] { 1 };
        protected int[] _projectIdArray = new int[] { 1 };
        protected int _hoursToOverdue = 0;

        public int[] UserIdList
        {
            get { return _userIdArray; }
            set
            {
                if (value != null)
                    _userIdArray = value;
            }
        }

        public int[] StatusIdList
        {
            get { return _statusIdArray; }
            set
            {
                if (value != null)
                    _statusIdArray = value;
            }
        }

        public int[] ProjectIdArray
        {
            get { return _projectIdArray; }
            set { _projectIdArray = value; }
        }

        public int HoursToOverdue
        {
            get { return _hoursToOverdue; }
            set { _hoursToOverdue = value; }
        }
        public Dashboard()
        {

        }
    }
}
