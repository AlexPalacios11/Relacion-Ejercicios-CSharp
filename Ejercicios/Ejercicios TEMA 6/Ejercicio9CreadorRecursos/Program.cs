using System.Globalization;
using CsvHelper;

namespace Ejercicio9CreadorRecursos;

internal class Program
{
    private const int DATA_SIZE = 1000;
    private const string DATA_FILENAME = "people.csv";

    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        for (int i = 0; i < DATA_SIZE; i++)
        {
            people.Add(new Person()
            {
                Id = Faker.RandomNumber.Next(),
                Name = Faker.Name.FullName(),
                Country = Faker.Country.Name(),
                Phone = Faker.Phone.Number(),
                Email = Faker.Internet.Email()
            });
        }

        using TextWriter fileReader = new StreamWriter(DATA_FILENAME);
        using CsvWriter csvWriter = new CsvWriter(fileReader, CultureInfo.InvariantCulture);

        csvWriter.WriteRecords(people);
    }
}