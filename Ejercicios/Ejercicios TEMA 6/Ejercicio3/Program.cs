namespace Ejercicio3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce la ruta de una carpeta existente");
        string directorio = Console.ReadLine();

        if (Directory.Exists(directorio))
        {
            Console.WriteLine();
            Show("Directorios", Directory.GetDirectories(directorio));
            Console.WriteLine();
            Console.WriteLine();
            Show("Archivos pdf", Directory.EnumerateFiles(directorio, "*.pdf", SearchOption.AllDirectories));          
        }
        else
        {
            Console.WriteLine("La ruta introducida no existe");
        }
    }

    private static void Show(string title, IEnumerable<string> rutas)
    {
        Console.WriteLine(title);

        foreach (string ruta in rutas)
        {
            Console.WriteLine(ruta);
        }
    }
}