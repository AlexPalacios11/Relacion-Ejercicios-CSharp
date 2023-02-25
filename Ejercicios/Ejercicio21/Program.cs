namespace Ejercicio21
{
    class Program
    {
        public enum DayOfWeak
        {
            monday, thuesday, wednesday, thursday, friday, saturday, sunday
        }
        public static void Main()
        {
            Console.Write("Introduzca un día de la semana: ");
            string day = Console.ReadLine();
            string day2 = day.ToLower();

            for (int i = 0; i < 7; i++)
            {
                string a = Convert.ToString((DayOfWeak)i);

                if (a == day2)
                {
                    if (i <= 4)
                    {
                        Console.WriteLine("Laborable");
                    }
                    else
                    {
                        Console.WriteLine("No laborable");
                    }
                }
            }

            Console.WriteLine("\nPulsa enter para cerrar");
            Console.ReadLine();
        }
    }
}