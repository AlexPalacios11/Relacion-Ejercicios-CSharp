namespace Ejercicio06
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca su edad: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else if (age < 18)
            {
                Console.WriteLine("Menor de edad");
            }
            else
            {
                Console.WriteLine("Activo");
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}