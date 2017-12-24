using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper
{
    public class Language
    {
        private string _LangName;
        private int _LangId = 0;
        private Dictionary<int, string> _Dict = new Dictionary<int, string>();

        public string LangName
        {
            get { return _LangName; }
            set { _LangName = value; }
        }
        public int LangId
        {
            get { return _LangId; }
            set { _LangId = value; }
        }
        public Dictionary<int, string> Dict
        {
            get { return _Dict; }
            set { _Dict = value; }
        }
        public Language(string LangName = "Русский" , int LangId = 1049)
        {
            _LangName = LangName;
            _LangId = LangId;
        }
    }
}
