using System.Xml.Serialization;

namespace ConfigTest.NetFramework
{
    public class Task
    {
        [XmlElement("TaskAdi")]
        public string TaskAdi { get; set; }
        [XmlElement("Tanim")]
        public string Tanim { get; set; }
    }
}
