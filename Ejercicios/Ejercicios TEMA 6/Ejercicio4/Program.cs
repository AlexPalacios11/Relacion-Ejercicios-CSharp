namespace Ejercicio4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe el nombre del fichero a crear");
        string filename = Console.ReadLine() + ".txt";

        Console.WriteLine("Escribe el contenido");
        string content = Console.ReadLine();

        using FileStream file = File.Create(filename);

        foreach (char letter in content)
            file.WriteByte((byte)letter);
    }
}