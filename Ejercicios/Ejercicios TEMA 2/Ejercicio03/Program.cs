namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas contraseñas quiere crear: ");
            int numeroContraseñas = int.Parse(Console.ReadLine());

            Password[] passwords = new Password[numeroContraseñas];
            bool[] esFuerte = new bool[passwords.Length];

            Console.WriteLine("Indique la longitud que quiere en las contraseñas: ");
            int tamaño = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroContraseñas; i++)
            {
                passwords[i] = new Password(tamaño);
                esFuerte[i] = passwords[i].EsFuerte();

                Console.WriteLine($"{passwords[i].Contrasena}  {esFuerte[i]}");
                Console.WriteLine();
            }
        }
    }
}