using ConsoleApp2;
using System.Drawing;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml.Serialization;

DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Squad));
Squad? squadFromJson = null;

try
{
    using (FileStream streamOpen = new FileStream("C:\\VS projects\\ConsoleApp1\\ConsoleApp2\\doc.json", FileMode.Open))
    {
        squadFromJson = (Squad?)serializer.ReadObject(streamOpen);
    }
}
catch (FileNotFoundException ex)
{
    Console.Write(ex.Message);
}

XmlSerializer serializerXml = new XmlSerializer(typeof(Squad));

using (FileStream streamCreate = new FileStream($"{squadFromJson?.SquadName}.xml", FileMode.Create))
{
    serializerXml.Serialize(streamCreate, squadFromJson);
}