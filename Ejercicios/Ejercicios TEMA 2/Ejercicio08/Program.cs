namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Comercial("Paco", 20, 300, 400);
            Empleado empleado2 = new Repartidor("Lucía", 18, 300, "zona 3");

            empleado1.AplicarPlus();
            empleado2.AplicarPlus();

            Console.WriteLine(empleado1.Salario);
            Console.WriteLine(empleado2.Salario);
        }
    }
}