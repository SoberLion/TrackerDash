using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    public class IssueJournalItem
    {
        private string IdField = string.Empty;
        private IdName UserField = null;
        private string NotesField = string.Empty;
        private string CreatedOnField = string.Empty;
        private List<Detail> DetailsField = new List<Detail>();

        [XmlArray("details")]
        [XmlArrayItem("detail")]
        public List<Detail> Details
        {
            get { return DetailsField; }
            set { DetailsField = value; }
        }

        [XmlAttribute("id")]
        public string Id
        {
            get { return IdField; }
            set { IdField = value; }
        }

        [XmlElement("user")]
        public IdName User
        {
            get { return UserField; }
            set { UserField = value; }
        }

        [XmlElement("notes")]
        public string Notes
        {
            get { return NotesField; }
            set { NotesField = value; }
        }

        [XmlElement("created_on", IsNullable = true)]
        public string CreatedOn
        {
            get { return CreatedOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    CreatedOnField = dt.ToString("yyyy-MM-dd HH:mm:00.000");
                }
                else
                    CreatedOnField = string.Empty;
            }
        }

        public class Detail
        {
            public Detail() { }

            private string PropertyField = string.Empty;
            private string NameField = string.Empty;
            private string OldValueField = string.Empty;
            private string NewValueField = string.Empty;

            [XmlAttribute("property")]
            public string Property
            {
                get { return PropertyField; }
                set { PropertyField = value; }
            }

            [XmlAttribute("name")]
            public string Name
            {
                get { return NameField; }
                set { NameField = value; }
            }

            [XmlElement("old_value")]
            public string OldValue
            {
                get { return OldValueField; }
                set { OldValueField = value; }
            }

            [XmlElement("new_value")]
            public string NewValue
            {
                get { return NewValueField; }
                set { NewValueField = value; }
            }
        }
    }
}
