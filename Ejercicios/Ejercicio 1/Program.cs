namespace Ejercicio01
{
    class Program
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("¿Como te llamas?");
            name = Console.ReadLine();
            Console.WriteLine("\"Hola, {0}\"", name);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}