namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una lista de números separados por comas: ");
            string[] listnumberstext = Console.ReadLine().Split(',');
            int[] listnumbers = new int[listnumberstext.Length];

            for (int i = 0;i< listnumbers.Length;i++)
            {
                listnumbers[i] = int.Parse(listnumberstext[i]);
            }

            int maxvalue = listnumbers[0];
            int minvalue = listnumbers[0];

            for (int i = 1; i < listnumbers.Length; i++)
            {
                if(maxvalue > listnumbers[i]) {}
                else
                {
                    maxvalue = listnumbers[i];
                }
            }
            for (int i = 1; i < listnumbers.Length; i++)
            {
                if (minvalue < listnumbers[i]) {}
                else
                {
                    minvalue = listnumbers[i];
                }
            }
            Console.WriteLine("El número más grande es {0}", maxvalue);
            Console.WriteLine("El número más pequeño es {0}", minvalue);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}
