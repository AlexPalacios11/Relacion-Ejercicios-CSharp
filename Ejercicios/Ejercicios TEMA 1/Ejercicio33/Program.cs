namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una lista de números separados por comas: ");
            string[] listnumbers = Console.ReadLine().Split(',');
            
            foreach (string i in listnumbers) 
            { 
                if (int.Parse(i)%2 == 0) Console.WriteLine(i);                  
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}
