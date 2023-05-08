using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Ejercicio10CreadorRecursos;

internal class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient client = new HttpClient();

        Dictionary<string, string> countries = await GetCountriesDictionaryAsync(client);
        IList<Contest> contests = await GetContestsAsync(client, countries);

        string json = JsonSerializer.Serialize(contests);
        File.WriteAllText("eurovision.json", json);
    }

    static async Task<Dictionary<string, string>> GetCountriesDictionaryAsync(HttpClient client)
    {
        string json = await client.GetStringAsync("https://raw.githubusercontent.com/josago97/EurovisionDataset/main/Dataset/countries.json");

        return JsonSerializer.Deserialize<Dictionary<string, string>>(json);
    }

    static async Task<IList<Contest>> GetContestsAsync(HttpClient client, Dictionary<string, string> countries)
    {
        List<Contest> result = new List<Contest>();
        string json = await client.GetStringAsync("https://raw.githubusercontent.com/josago97/EurovisionDataset/main/Dataset/eurovision.json");

        JsonArray jContests = JsonNode.Parse(json).AsArray();

        foreach (JsonNode jContest in jContests)
        {
            int year = jContest["year"].GetValue<int>();

            if (year != 2020)
            {
                List<Contestant> contestants = new List<Contestant>();
                JsonArray jContestants = jContest["contestants"].AsArray();
                JsonArray jFinalPerformances = jContest["rounds"].AsArray()
                    .Single(jRound => jRound["name"].GetValue<string>() == "final")
                    ["performances"].AsArray();

                foreach (JsonNode jContestant in jContestants)
                {
                    JsonNode jFinalPerformance = jFinalPerformances.SingleOrDefault(jPerformance =>
                    {
                        int contestantId = jContestant["id"].GetValue<int>();
                        int performanceContestantId = jPerformance["contestantId"].GetValue<int>();

                        return contestantId == performanceContestantId;
                    });

                    if (jFinalPerformance != null)
                    {
                        contestants.Add(new Contestant()
                        {
                            Country = countries[jContestant["country"].GetValue<string>()],
                            Place = jFinalPerformance["place"].GetValue<int>()
                        });
                    }
                }

                result.Add(new Contest()
                {
                    Year = year,
                    Country = countries[jContest["country"].GetValue<string>()],
                    Contestants = contestants
                });
            }
        }


        return result;
    }
}