namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce el dividendo");
                int dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el divisor");
                int divisor = int.Parse(Console.ReadLine());

                int conciente = dividendo / divisor;

                Console.WriteLine("El conciente es {0}", conciente);
            }
            catch(Exception a)
            {
                Console.WriteLine("Se ha generado un error: {0}", a.Message);
            }
            
            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
        
    }
}
