namespace Ejercicio7CreadorRecursos;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        using StreamWriter fileWriter = new StreamWriter("temperaturas.dat"); // Por defecto usa UTF8

        DateOnly date = new DateOnly(2000, 1, 1);
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        while (date != today)
        {
            int temperature = random.Next(0, 50);
            fileWriter.WriteLine($"{date} {temperature}");
            date = date.AddDays(1);
        }
    }
}