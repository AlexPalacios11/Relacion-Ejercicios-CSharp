namespace Ejercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número entero positivo: ");  
            int number = int.Parse(Console.ReadLine());

            int[] listnumbers = new int[number];  
            Random random= new Random();
            for (int i = 0; i < number; i++) 
            {
                int numberRandom = random.Next();
                do
                {
                    listnumbers[i] = numberRandom;
                }
                while (Contains(listnumbers, numberRandom));
                

            }

            Console.WriteLine(String.Join(", ", listnumbers));

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }  
        static bool Contains(int[] array, int item)
        {
            bool found = false;

            for (int i = 0; i < array.Length && !found; i++) 
            {
                int num = array[i];

                if (num == item) { found = true; }
            }

            return found;
        }
    }
}
