namespace Ejercicio1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce la ruta de un archivo existente");
        string path = Console.ReadLine();

        string nombre = Path.GetFileNameWithoutExtension(path);
        Console.WriteLine($"El archivo se llama: {nombre}");

        string extension = Path.GetExtension(path);
        Console.WriteLine($"La extension es {extension}");

        string directorio = Path.GetFileName(Path.GetDirectoryName(path));
        Console.WriteLine($"El archivo está en la carpeta {directorio}");

        string archivoMP3 = Path.ChangeExtension(path, ".mp3");
        Console.WriteLine($"La ruta nueva con el formato MP3 es: {archivoMP3}");

        string rutaAbsoluta = Path.GetFullPath(Path.GetFileName(path));
        Console.WriteLine(rutaAbsoluta);
    }
}