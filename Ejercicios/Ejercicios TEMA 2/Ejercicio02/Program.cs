using System.Security.Cryptography.X509Certificates;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca una edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un género: ");
            Persona.Genero sexo = (Persona.Genero)Enum.Parse(typeof(Persona.Genero), Console.ReadLine(), true);
            Console.Write("Introduzca un peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Introduzca una altura: ");
            double altura = double.Parse(Console.ReadLine());

            Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3 = new Persona();

            persona3.Nombre = nombre;
            persona3.Edad = edad;
            persona3.Sexo = sexo;
            persona3.Peso = peso;
            persona3.Altura = altura;

            
            Console.WriteLine(persona1);
            ComprobarPeso(persona1);
            MayorDeEdad(persona1);
            
            Console.WriteLine();

            Console.WriteLine(persona2);
            ComprobarPeso(persona2);
            MayorDeEdad(persona2);

            Console.WriteLine();

            Console.WriteLine(persona3);
            ComprobarPeso(persona3);
            MayorDeEdad(persona3);

            static void ComprobarPeso(Persona persona)
            {
                int imc = persona.CalcularIMC();

                if (imc == Persona.DEBAJO_PESO_IDEAL) Console.WriteLine("Está por debajo de su peso ideal");
                else if (imc == Persona.PESO_IDEAL) Console.WriteLine("Está en su peso ideal");
                else Console.WriteLine("Está por encima de su peso ideal");

            }
            static void MayorDeEdad(Persona persona)
            {
                if (persona.EsMayorDeEdad()) Console.WriteLine("Es mayor de edad");
                else Console.WriteLine("No es mayor edad");
            }
        }
    }
}