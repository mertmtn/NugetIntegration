using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConfigTest.NetFramework
{
    [XmlRoot("TaskList")]
    public class ToDoList
    {
        [XmlElement("Task")]
        public List<Task> TaskList { get; set; }
    }
}
