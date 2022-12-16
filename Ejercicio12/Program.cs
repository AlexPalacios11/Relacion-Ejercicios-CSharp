namespace Ejercicio12
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Escriba una palabra: ");
            string word = Console.ReadLine();
            string inverted = "";

            for (int cont = word.Length - 1; cont >= 0; cont--)
            {
                char c = word[cont];
                inverted += Convert.ToString(c);
            }

            if (inverted == word)
            {
                Console.WriteLine("La palabra es un palíndromo");
            }
            else
            {
                Console.WriteLine("La palabra no es un palíndromo");
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}