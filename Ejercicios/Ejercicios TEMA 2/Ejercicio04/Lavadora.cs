namespace Ejercicio04
{
    internal class Lavadora : Electrodomestico
    {
        private const double CARGA_DEFAULT = 5;

        private double carga;

        public double Carga { get => carga; }

        public Lavadora(double carga, double precioBase, Colores color, Consumo consumoEner, double peso) : base (precioBase, color, consumoEner, peso)
        {
            this.carga = carga;
        }
        public Lavadora(double precioBase, double peso) : this (CARGA_DEFAULT, precioBase, COLOR_DEFAULT, CONSUMO_DEFAULT, peso)
        { 
        }
        public Lavadora() : this (PRECIO_BASE_DEFAULT, PESO_DEFAULT)
        {
        }
        public override void PrecioFinal()
        {
            base.PrecioFinal();

            if (carga > 30) precioBase += 50;
        }
    }
}
