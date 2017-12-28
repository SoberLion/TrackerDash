using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    public class IdName : IComparer<IdName>, System.IComparable<IdName>
    {
        public IdName() { }

        private int idField = -1;
        private string nameField = string.Empty;

        [XmlAttribute]
        public int id
        {
            get { return idField; }
            set { idField = value; }
        }
        [XmlAttribute]
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }

        public int Compare(IdName x, IdName y)
        {
            int i = 0;
            if (x.id > y.id)
                i = 1;
            if (x.id < y.id)
                i = -1;
            return i;
        }

        public int CompareTo(IdName other)
        {
            return Compare(this, other);
        }
    }

    public class IdNameComparer : IEqualityComparer<IdName>
    {
        public bool Equals(IdName x, IdName y)
        {
            return x.id.Equals(y.id);
        }

        public int GetHashCode(IdName obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 0;

            return obj.id.GetHashCode();
        }
    }
}
