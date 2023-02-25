namespace Ejercicio08
{
    internal class Repartidor : Empleado
    {
        private const int EDAD_MAXIMA = 25;
        private const string ZONA = "zona 3";

        private string zona;

        public string Zona { get => zona; set => zona = value; }

        public Repartidor(string nombre, int edad, int salario, string zona) : base(nombre, edad, salario)
        {
            this.zona = zona;
        }
        public override string ToString()
        {
            return base.ToString() + $"Zona: {zona}";
        }
        public override void AplicarPlus()
        {
            if (Edad < 25 && Zona == ZONA)
            {
                Salario += PLUS;
            }
        }
    }
}
