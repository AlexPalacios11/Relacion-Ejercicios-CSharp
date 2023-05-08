using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Ejercicio10;

[XmlType("contest")]
public class Contest
{
    [JsonPropertyName("year")]
    [XmlElement("year")]
    public int Year { get; set; }
    [JsonPropertyName("country")]
    [XmlElement("country")]
    public string Country { get; set; }
    [JsonPropertyName("contestants")]
    [XmlArray("contestants")]
    public List<Contestant> Contestants { get; set; }
}
