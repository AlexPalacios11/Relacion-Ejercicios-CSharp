using System.Globalization;

namespace Ejercicio28
{
    class Program
    {
        enum Option { Circle, Triangle, Square };
        static void Main(string[] args) 
        {
            

            Console.Write("Elige opción (Círculo = 0, Triángulo = 1, Cuadrado = 2): ");
            Option option = (Option)int.Parse(Console.ReadLine());
            
            double area = 0;
            
            switch (option)
            {
                case Option.Circle:
                    area = CalcularCirculo();
                    break;
                case Option.Triangle:
                    area = CalcularTriangulo();
                    break;
                case Option.Square:
                    area = CalcularCuadrado();
                    break;
            }
            Console.WriteLine("El area es: {0}",area);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
        static double CalcularCirculo()
        {  
            Console.Write("Introduce el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
            return Math.PI * radio * radio;
        }
        static double CalcularTriangulo()
        {
            Console.Write("Introduce la base del triángulo: ");
            double @base = double.Parse(Console.ReadLine());
            Console.Write("Introduce la altura del triángulo: ");
            double altura = double.Parse(Console.ReadLine());
            return @base * altura / 2;
        }
        static double CalcularCuadrado()
        {
            Console.Write("Introduce el lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            return lado * lado;
        }
    }
}