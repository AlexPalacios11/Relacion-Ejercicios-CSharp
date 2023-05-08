using System.Text.Json;
using System.Xml.Serialization;

namespace Ejercicio11;

internal class Program
{
    static void Main(string[] args)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Contest[]));
        using FileStream fileStream = File.OpenRead("../../../../Ejercicio10/bin/Debug/net7.0/eurovision.xml");
        IEnumerable<Contest> contests = xmlSerializer.Deserialize(fileStream) as Contest[];

        contests = contests.Where(contest => contest.Year >= 2000);

        string json = JsonSerializer.Serialize(contests);
        File.WriteAllText("eurovision.json", json);
    }
}