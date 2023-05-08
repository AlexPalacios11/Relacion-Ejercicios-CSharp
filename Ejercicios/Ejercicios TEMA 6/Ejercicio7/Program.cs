using System.Text;

namespace Ejercicio7;

internal class Program
{
    static void Main(string[] args)
    {
        string filePath = "../../../../Ejercicio7CreadorRecursos/bin/Debug/net7.0/temperaturas.dat";

        LeerConFileStream(filePath);

        LeerConStreamReader(filePath);
    }

    private static void LeerConFileStream(string filePath)
    {
        using FileStream file = File.OpenRead(filePath);
        
        StringBuilder stringBuilder = new StringBuilder();
        byte[] buffer = new byte[1024];
        int bytesRead = 0;

        while ((bytesRead = file.Read(buffer, 0, buffer.Length)) > 0)
        {
            string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            stringBuilder.Append(content);
        }

        string fileContent = stringBuilder.ToString();
        string[] lines = fileContent.ReplaceLineEndings("\n").Split("\n"); // Windows \n\r Otro: \n
        int maxTemperature = int.MinValue;
        string maxTemperatureDate = null;

        foreach (string line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                string[] data = line.Split(' ');
                int temperature = int.Parse(data[1]);

                if (temperature > maxTemperature)
                {
                    maxTemperature = temperature;
                    maxTemperatureDate = data[0];
                }
            }
        }

        Console.WriteLine($"{maxTemperatureDate} => {maxTemperature}º");
    }

    private static void LeerConStreamReader(string filePath)
    {
        using StreamReader file = File.OpenText(filePath); // Por defecto usa UTF8

        string line;
        int maxTemperature = int.MinValue;
        string maxTemperatureDate = null;

        while (!string.IsNullOrEmpty(line = file.ReadLine()))
        {
            string[] data = line.Split(' ');
            int temperature = int.Parse(data[1]);

            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
                maxTemperatureDate = data[0];
            }
        }

        Console.WriteLine($"{maxTemperatureDate} => {maxTemperature}º");
    }
}