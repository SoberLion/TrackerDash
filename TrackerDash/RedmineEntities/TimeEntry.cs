using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    public partial class Time_entry
    {
        private string _id;
        private string _hours;
        private string _comments;
        private string _spent_on;
        private string _created_on;
        private string _updated_on;
        private IdName _project;
        private IdName _issue;
        private IdName _user;
        private IdName _activity;

        [XmlElement("id")]
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement("hours")]
        public string hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        [XmlElement("comments")]
        public string comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        [XmlElement("spent_on")]
        public string spent_on
        {
            get { return _spent_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _spent_on = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    _spent_on = string.Empty;
            }
        }

        [XmlElement("created_on")]
        public string created_on
        {
            get { return _created_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _created_on = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    _created_on = string.Empty;
            }
        }

        [XmlElement("updated_on")]
        public string updated_on
        {
            get { return _updated_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _updated_on = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    _updated_on = string.Empty;
            }
        }

        [XmlElement("project")]
        public IdName project
        {
            get { return _project; }
            set { _project = value; }
        }

        [XmlElement("issue")]
        public IdName issue
        {
            get { return _issue; }
            set { _issue = value; }
        }

        [XmlElement("user")]
        public IdName user
        {
            get { return _user; }
            set { _user = value; }
        }

        [XmlElement("activity")]
        public IdName activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
    }
}
