namespace Ejercicio5;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe la ruta del fichero a leer");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using StreamReader file = File.OpenText(filename);
            Console.WriteLine(file.ReadToEnd());
        }
        else
        {
            Console.WriteLine("La ruta indicada no existe");
        }
    }
}