namespace Ejercicio08
{
    internal class Comercial : Empleado
    {
        private const int EDAD_MINIMA = 30;
        private const int COMISION_MINIMA = 200;


        private double comision;

        public double Comision { get => comision; set => comision = value; }

        public Comercial(string nombre, int edad, int salario, double comision) : base(nombre, edad, salario)
        {
            this.comision = comision;
        }
        public override string ToString()
        {
            return base.ToString() + $"Comisión: {comision}";
        }
        public override void AplicarPlus()
        {
            if(Edad > EDAD_MINIMA && Comision > COMISION_MINIMA)
            {
                Salario += PLUS;
            }
        }
    }
}
