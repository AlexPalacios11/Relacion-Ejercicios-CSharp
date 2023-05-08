using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Ejercicio10;

[XmlType("contestant")]
public class Contestant
{
    [JsonPropertyName("country")]
    [XmlElement("country")]
    public string Country { get; set; }
    [JsonPropertyName("place")]
    [XmlElement("place")]
    public int Place { get; set; }
}
