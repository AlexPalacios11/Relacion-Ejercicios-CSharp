namespace Ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una lista de números separados por comas: ");
            string[] listnumberstext = Console.ReadLine().Split(',');
            int[] listnumbers = new int[listnumberstext.Length];
            for (int i = 0; i < listnumberstext.Length; i++)
            {
                listnumbers[i] = int.Parse(listnumberstext[i]);
            }

            for (int i = 0; i < listnumbers.Length; i++) 
            { 
                for (int j = i+1; j < listnumbers.Length; j++)
                {
                    int aux;
                    if (listnumbers[i] > listnumbers[j])
                    {
                        aux = listnumbers[i];
                        listnumbers[i] = listnumbers[j];
                        listnumbers[j] = aux;
                    }
                }
            }

            Console.Write("Números ordenados: ");
            for (int i=0; i< listnumbers.Length; i++)
            {
                Console.Write(listnumbers[i] + " ");
            }
            Console.ReadKey();
            
            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}