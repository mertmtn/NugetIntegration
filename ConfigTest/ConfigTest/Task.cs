// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

public class Task
{
    [XmlElement("TaskAdi")]
    public string TaskAdi { get; set; }
    [XmlElement("Tanim")]
    public string Tanim { get; set; }
}