namespace Ejercicio04
{
    internal class Television : Electrodomestico
    {
        private const double RESOLUCION_DEFAULT = 20;
        private const bool SINTONIZADOR_DEFAULT = false;

        private double resolucion;
        private bool sintonizadorTDT;

        public double Resolucion { get => resolucion; }
        public bool Sintonizador { get => sintonizadorTDT; }

        public Television(double resolucion, bool sintonizador, double precioBase, Colores color, Consumo consumoEner, double peso)
            : base (precioBase, color, consumoEner, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizador;
        }
        public Television(double precioBase, double peso) : this (RESOLUCION_DEFAULT, SINTONIZADOR_DEFAULT, precioBase, COLOR_DEFAULT, CONSUMO_DEFAULT, peso)
        {
        }
        public Television() : this (PRECIO_BASE_DEFAULT, PESO_DEFAULT)
        {
        }
        public override void PrecioFinal()
        {
            base.PrecioFinal();

            if (resolucion > 40) precioBase *= 1.3;
            if (sintonizadorTDT == true) precioBase += 50;
        }
    }
}
