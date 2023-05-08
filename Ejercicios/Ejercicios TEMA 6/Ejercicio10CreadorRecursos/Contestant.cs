using System.Text.Json.Serialization;

namespace Ejercicio10CreadorRecursos;

public class Contestant
{
    [JsonPropertyName("country")]
    public string Country { get; set; }
    [JsonPropertyName("place")]
    public int Place { get; set; }
}
