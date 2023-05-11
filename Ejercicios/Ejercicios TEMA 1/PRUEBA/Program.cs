using System;
using System.Net;
using System.Text.RegularExpressions;

namespace SubnetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Pedir dirección IP y máscara de red al usuario
            Console.Write("Introduce la dirección IP en formato CIDR (p.ej. 192.168.1.0/24): ");
            string input = Console.ReadLine();

            // Validar dirección IP y máscara de red con Regex
            Match match = Regex.Match(input, @"^(\d{1,3}\.){3}\d{1,3}/\d{1,2}$");
            if (!match.Success)
            {
                Console.WriteLine("Formato de entrada no válido. Introduce una dirección IP y máscara de red en formato CIDR.");
                return;
            }

            // Obtener dirección IP y máscara de red de la entrada del usuario
            string[] ipAndMask = input.Split('/');
            string ipString = ipAndMask[0];
            int maskBits = int.Parse(ipAndMask[1]);

            // Validar dirección IP
            IPAddress ipAddress;
            if (!IPAddress.TryParse(ipString, out ipAddress))
            {
                Console.WriteLine("La dirección IP introducida no es válida.");
                return;
            }

            // Validar máscara de red
            if (maskBits < 0 || maskBits > 32)
            {
                Console.WriteLine("La máscara de red introducida no es válida.");
                return;
            }

            // Paso 2: Pedir número de hosts necesarios por subred
            Console.Write("Introduce el número de hosts necesarios por subred: ");
            int numHosts = int.Parse(Console.ReadLine());

            // Validar número de hosts
            if (numHosts <= 0 || numHosts >= Math.Pow(2, 32 - maskBits) - 2)
            {
                Console.WriteLine("El número de hosts introducido no es válido para la máscara de red especificada.");
                return;
            }

            // Paso 3: Calcular subredes posibles
            int numSubnets = (int)Math.Pow(2, 32 - maskBits);

            // Mostrar información de cada subred
            for (int i = 0; i < numSubnets; i++)
            {
                // Calcular dirección IP de la subred
                uint ip = BitConverter.ToUInt32(ipAddress.GetAddressBytes(), 0);
                uint subnetIp = ip + (uint)(i << (32 - maskBits));

                // Crear objeto IPAddress a partir de la dirección IP de la subred
                byte[] subnetIpBytes = BitConverter.GetBytes(subnetIp);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(subnetIpBytes);
                }
                IPAddress subnetIpAddress = new IPAddress(subnetIpBytes);

                // Calcular dirección de broadcast de la subred
                uint subnetMask = ~(uint.MaxValue >> maskBits);
                uint broadcastIp = subnetIp | ~subnetMask;
                byte[] broadcastIpBytes = BitConverter.GetBytes(broadcastIp);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(broadcastIpBytes);
                }
                IPAddress broadcastIpAddress = new IPAddress(broadcastIpBytes);

                // Calcular número de hosts asignables
                int numAssignableHosts = (int)Math.Pow(2, 32 - maskBits) - 2;

                // Mostrar información de la subred
                Console.WriteLine($"Subred {i + 1}: ");
                Console.WriteLine($"Dirección IP: {subnetIpAddress}");
                Console.WriteLine($"Máscara de red: {subnetMask}");
                Console.WriteLine($"Direcciones asignables: {numAssignableHosts}");
                Console.WriteLine($"Dirección de broadcast: {broadcastIpAddress}");
                Console.WriteLine();
            }
        }
    }
}

