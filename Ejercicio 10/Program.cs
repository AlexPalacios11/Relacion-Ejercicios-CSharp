Console.Write("Introduzca un número entero: ");
int number = Convert.ToInt32(Console.ReadLine());
int contador;

for (contador = 0; contador <= number; contador++)
{
    for (; number >= 1; number--)
    {
        if (number % 2 == 0 && number % 3 == 0)
        {
            Console.WriteLine("El número {0} es divisible entre 2 y 3", number);
        }
    }
}


