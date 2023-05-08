namespace Ejercicio6;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe un texto");
        string secreto = Console.ReadLine();

        using FileStream fichero = File.Open("texto.txt", FileMode.Create);

        foreach (char letra in secreto)
            fichero.WriteByte((byte)letra);

        // Vuelvo al principio y leo
        fichero.Position = 0;
        byte[] buffer = new byte[1024];
        int bytesReaded = 0;

        while ((bytesReaded = fichero.Read(buffer)) > 0)
        {
            for (int i = 0; i < bytesReaded; i++)
            {
                Console.Write((char)buffer[i]);
            }
        }

        Console.WriteLine();

        Console.WriteLine($"El archivo pesa {fichero.Length} bytes");
    }
}