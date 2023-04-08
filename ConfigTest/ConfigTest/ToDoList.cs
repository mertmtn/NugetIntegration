// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

[XmlRoot("TaskList")]
public class ToDoList
{
    [XmlElement("Task")]
    public List<Task> TaskList { get; set; }
}
