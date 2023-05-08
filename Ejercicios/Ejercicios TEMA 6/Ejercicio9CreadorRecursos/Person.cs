using CsvHelper.Configuration.Attributes;

namespace Ejercicio9CreadorRecursos;

public class Person
{
    [Name("id")]
    public int Id { get; set; }
    [Name("name")]
    public string Name { get; set; }
    [Name("country")]
    public string Country { get; set; }
    public string Phone { get; set; }
    [Name("e-mail")]
    public string Email { get; set; }
}
