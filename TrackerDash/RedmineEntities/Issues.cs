using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    [XmlRoot("issues", IsNullable = false)]
    public class Issues
    {
        private int _total_count = 0;
        private int _offset = 0;
        private int _limit = 100;
        private string _type = string.Empty;
        private List<Issue> issueField = new List<Issue>();

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

        [XmlElement(IsNullable = false)]
        public List<Issue> issue
        {
            get { return issueField; }
            set { issueField = value; }
        }

        public void IncOffset() => offset = total_count - offset < limit ? total_count : offset + limit;
    }
}
