namespace Ejercicio11_2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introduce un número entero:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++) //El número 1 no es primo
            {
                bool isPrime = true;
                //Comprobamos desde el 2 hasta i/2 ya que 1 siempre va a ser diferente
                //Como máximo un número se va a poder dividir entre su mitad

                for (int j = 2; j <= i / 2 && isPrime; j++)
                {
                    if (i % j == 0) isPrime = false;
                }
                if (isPrime) Console.WriteLine(i);
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}