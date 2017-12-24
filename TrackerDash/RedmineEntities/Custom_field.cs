using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    [XmlRoot("custom_field")]
    public class custom_field
    {
        public custom_field() { }

        private int idField;
        private string nameField;
        private bool multipleField;
        private List<Value> valueField;

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

        [XmlAttribute]
        public bool multiple
        {
            get { return multipleField; }
            set { multipleField = value; }
        }

        [XmlElement("value")]
        public List<Value> value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
    [XmlRoot("value")]
    public class Value
    {
        private string V_type;
        private string valueField;

        [XmlAttribute("type")]
        public string type
        {
            get { return V_type; }
            set { V_type = value; }
        }
        [XmlText]
        public string value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        public Value() { }
    }
}
