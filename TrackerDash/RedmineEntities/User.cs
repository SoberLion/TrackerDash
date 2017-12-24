using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    public class user
    {
        private int _id = 0;
        private string _login = string.Empty;
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private string _mail = string.Empty;
        private string _created_on = string.Empty;
        private string _last_login_on = string.Empty;
        private List<custom_field> _custom_fields = new List<custom_field>();

        [XmlElement]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        [XmlElement]
        public string login
        {
            get { return _login; }
            set { _login = value; }
        }
        [XmlElement]
        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        [XmlElement]
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        [XmlElement]
        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        [XmlElement]
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
        [XmlElement]
        public string last_login_on
        {
            get { return _last_login_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _last_login_on = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    _last_login_on = string.Empty;
            }
        }


        [XmlArray("custom_fields")]
        [XmlArrayItem("custom_field")]
        public List<custom_field> custom_fields
        {
            get { return _custom_fields; }
            set { _custom_fields = value; }
        }
    }
}
