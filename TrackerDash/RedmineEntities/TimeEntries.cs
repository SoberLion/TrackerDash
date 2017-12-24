using System.Collections.Generic;
using System.Xml.Serialization;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper
{
    [XmlRoot("time_entries", IsNullable = false)]
    public class Time_entries
    {
        public Time_entries() { }

        private List<Time_entry> _time_entry = new List<Time_entry>();
        private int _total_count;
        private int _offset;
        private int _limit;
        private string _type;

        [XmlElement("time_entry")]
        public List<Time_entry> time_entry_list
        {
            get
            {
                return _time_entry;
            }
            set { _time_entry = value; }
        }

        [XmlAttribute]
        public int total_count
        {
            get { return _total_count; }
            set { _total_count = value; }
        }

        [XmlAttribute]
        public int offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        [XmlAttribute]
        public int limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        [XmlAttribute]
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void IncOffset()
        {
            offset = total_count - offset < limit ? total_count : offset + limit;
        }
    }
}
