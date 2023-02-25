using System.Runtime.CompilerServices;

namespace Ejercicio02
{
    internal class Persona
    {
        public enum Genero { Hombre, Mujer };

        private const Genero SEXO_DEFAULT = Genero.Hombre;
        public const int DEBAJO_PESO_IDEAL = -1;
        public const int PESO_IDEAL = 0;
        public const int SOBREPESO = 1;
        private const string DNI_LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";

        private string nombre;
        private int edad;
        private string dni;
        private Genero sexo;
        private double peso;
        private double altura;

        public string Nombre { set => nombre = value; }
        public int Edad { set => edad = value; }
        public Genero Sexo { set => sexo = value; }
        public double Peso { set => peso = value; }
        public double Altura { set => altura = value; }
        public Persona(string nombre, int edad, Genero sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            dni = GenerarDNI();
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        public Persona(string nombre, int edad, Genero sexo) : this (nombre, edad, sexo, 0, 0)
        {
        }
        public Persona() : this(String.Empty, 0, SEXO_DEFAULT, 0, 0)
        {
        }

        public int CalcularIMC()
        {
            int result;
            double imc = peso * (altura * altura);
            if (imc < 20) result = DEBAJO_PESO_IDEAL;
            else if (imc > 25) result = SOBREPESO;
            else result = PESO_IDEAL;

            return result;
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}\nEdad: {edad}\nDNI: {dni}\nGénero: {sexo}\nPeso: {peso}\nAltura: {altura}";
        }
        private string GenerarDNI()
        {
            int numero = GenerarNumeroAleatorio();
            char letra = DNI_LETTERS[numero % DNI_LETTERS.Length];

            return numero.ToString() + letra;
        }

        private int GenerarNumeroAleatorio()
        {
            Random random = new Random();

            return random.Next(1, 100000000);
        }


    }
}
