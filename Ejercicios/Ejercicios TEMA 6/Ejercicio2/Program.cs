namespace Ejercicio2;

internal class Program
{
    static void Main(string[] args)
    {
        string path = "Cosas/Otras cosas";

        if (!Directory.Exists(path))
        {
            DirectoryInfo info = Directory.CreateDirectory(path);
            Console.WriteLine(info.CreationTime);
        }

        string parent = Path.GetDirectoryName(path);
        Directory.Delete(parent, true);
    }
}