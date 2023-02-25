namespace Ejercicio17
{
    class Program
    {
        public static void Main()
        {

            Console.Write("Introducir frase: ");
            string initialphrase = Console.ReadLine();
            string secondphrase = initialphrase.ToUpper();
            string phrase = secondphrase.Replace(" ", String.Empty);



            while (phrase.Length > 0)
            {
                Console.Write(phrase[0] + " = ");
                int cont = 0;
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (phrase[0] == phrase[i])
                    {
                        cont++;
                    }
                }
                Console.WriteLine(cont);
                phrase = phrase.Replace(phrase[0].ToString(), string.Empty);
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}      