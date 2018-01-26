using System;
using System.IO;
using System.Xml.Serialization;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper
{
    class XML
    {
        public static T Deserialize<T>(string XmlString) where T : class
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

        /*        ser.UnknownNode += (s, ea) =>
                {
                    if (ea.LocalName == "#text" && ea.ObjectBeingDeserialized is Value)
                    {
                        Value val = (Value)ea.ObjectBeingDeserialized;
                        if (val.value == null)
                            val.value = ea.Text;
                    }
                };*/

                using (StringReader sr = new StringReader(XmlString))
                    return (T)ser.Deserialize(sr);
            }
            catch
            {
                return null;
            }
        }



    }
}
