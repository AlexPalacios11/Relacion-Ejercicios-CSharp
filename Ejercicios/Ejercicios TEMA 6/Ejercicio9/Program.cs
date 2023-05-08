using System.Globalization;
using CsvHelper;

namespace Ejercicio9;

internal class Program
{
    static void Main(string[] args)
    {
        using StreamReader streamReader = new StreamReader("../../../../Ejercicio9CreadorRecursos/bin/Debug/net7.0/people.csv");
        using CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

        var people = csvReader.GetRecords<Person>();

        people = people.Where(person => person.Name.Length < 10);

        using StreamWriter streamWriter = new StreamWriter("people2.csv");
        using CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

        csvWriter.WriteRecords(people);
    }
}