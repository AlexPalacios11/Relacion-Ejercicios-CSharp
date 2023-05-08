using System.Text.Json.Serialization;

namespace Ejercicio10CreadorRecursos;

public class Contest
{
    [JsonPropertyName("year")]
    public int Year { get; set; }
    [JsonPropertyName("country")]
    public string Country { get; set; }
    [JsonPropertyName("contestants")]
    public IList<Contestant> Contestants { get; set; }
}
