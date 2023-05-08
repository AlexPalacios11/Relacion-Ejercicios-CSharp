using System.Text;

namespace Ejercicio13CreadorRecursos;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        byte separation = 30;
        string message = "¡Hola mundo!";
        byte[] messageEncoded = Encoding.UTF32.GetBytes(message);

        using FileStream file = File.Create("secreto.txt");
        file.WriteByte(separation);

        byte[] randomBuffer = new byte[separation];

        foreach (byte messageByte in messageEncoded)
        {
            random.NextBytes(randomBuffer);
            file.Write(randomBuffer);
            file.WriteByte(messageByte);
        }
    }
}