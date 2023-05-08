using System.Text.Json;
using System.Xml.Serialization;

namespace Ejercicio10;

internal class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("../../../../Ejercicio10CreadorRecursos/bin/Debug/net7.0/eurovision.json");
        Contest[] contests = JsonSerializer.Deserialize<Contest[]>(json);

        string mostWins = contests.SelectMany(contest => contest.Contestants)
            .GroupBy(contestant => contestant.Country)
            .MaxBy(group => group.Count(contestant => contestant.Place == 1))
            .Key;

        contests = contests.Where(contest => contest.Country != mostWins).ToArray();

        XmlSerializer xmlSerializer = new XmlSerializer(contests.GetType());
        using FileStream fileStream = File.OpenWrite("eurovision.xml");
        xmlSerializer.Serialize(fileStream, contests);
    }
}