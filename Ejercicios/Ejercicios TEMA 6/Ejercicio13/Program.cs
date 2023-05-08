using System.Text;

namespace Ejercicio13;

internal class Program
{
    static void Main(string[] args)
    {
        string filePath = "../../../../Ejercicio13CreadorRecursos/bin/Debug/net6.0/secreto.txt";

        using FileStream file = File.OpenRead(filePath);

        List<byte> messageEncoded = new List<byte>();
        int separation = file.ReadByte();
        byte[] separationBuffer = new byte[separation];

        while (file.Position < file.Length)
        {
            file.Read(separationBuffer);
            messageEncoded.Add((byte)file.ReadByte());
        }

        string message = Encoding.UTF32.GetString(messageEncoded.ToArray());
        Console.WriteLine(message);

    }
}