namespace Ejercicio05
{
    internal class Persona
    {
        private static readonly string LETRAS_DNI = "TRWAGMYFPDXBNJZSQVHLCKE";
        private const int EDAD_MINIMA = 18;

        private string nombre;
        private int edad;
        private string dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value + CalcularLetraDni(value); }
        
        public Persona(string nombre, int edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            Dni = dni;
        }
        private char CalcularLetraDni(string dni)
        {
            int numero = int.Parse(dni);
            int resto = numero % LETRAS_DNI.Length;

            return LETRAS_DNI[resto];
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}\nEdad: {edad} años\nDNI: {Dni}";
        }
        public bool EsMayorDeEdad()
        {
            return edad >= EDAD_MINIMA;
        }


    }
}
