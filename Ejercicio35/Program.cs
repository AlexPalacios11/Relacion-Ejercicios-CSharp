namespace Ejercicio35
{
    class Program
    {
        static readonly char[] letters = {'T','R','W','A','G','M','Y','F','P','D','X','B','N','J','Z','S','Q','V','H','L','C','K','E'};
        static void Main(string[] args)
        {
            Console.Write("Introduzca su DNI sin la letra: ");
            int DNI = int.Parse(Console.ReadLine());
            int rest = DNI % 23;
            char letter = ' ';

            for (int i=0; i<letters.Length; i++) 
            {
                if (rest == i)
                    letter = letters[i];    
            }
            Console.WriteLine("{0}{1}", DNI, letter);

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}