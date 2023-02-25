using static Ejercicio04.Electrodomestico;

namespace Ejercicio04
{
    internal class Electrodomestico
    {
        public enum Consumo { A, B, C, D, E, F }
        public enum Colores { Blanco, Negro, Rojo, Azul, Gris }

        protected const Colores COLOR_DEFAULT = Colores.Blanco;
        protected const Consumo CONSUMO_DEFAULT = Consumo.F;
        protected const double PRECIO_BASE_DEFAULT = 100;
        protected const double PESO_DEFAULT = 5;

        protected double precioBase;
        protected Colores color;
        protected Consumo consumoEner;
        protected double peso;

        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public Colores Color { get => color; set => color = value; }
        public Consumo ConsumoEner { get => consumoEner; set => consumoEner = value; }
        public double Peso { get => peso; set => peso = value; }

        public Electrodomestico(double precioBase, Colores color, Consumo consumoEner, double peso)
        {
            this.precioBase = precioBase;
            ComprobarColor(color);
            ComprobarConsumoEnergetico(consumoEner);
            this.peso = peso;
        }
        public Electrodomestico(double precioBase, double peso) : this (precioBase, COLOR_DEFAULT, CONSUMO_DEFAULT, peso)
        {
        }
        public Electrodomestico() : this (PRECIO_BASE_DEFAULT, PESO_DEFAULT)
        {
        }
        private void ComprobarConsumoEnergetico(Consumo consumo)
        {
            if ((char)consumo < 'A' || (char)consumo > 'F') consumoEner = CONSUMO_DEFAULT;
            else consumoEner = consumo;
        }

        private void ComprobarColor(Colores color)
        {
            if (color < Colores.Blanco || color > Colores.Gris) this.color = COLOR_DEFAULT;
            else this.color = color;
        }
        public virtual void PrecioFinal()
        {
            PrecioConsumo();
            PrecioTamaño();
        }
        public void PrecioConsumo()
        {
            if (consumoEner == Consumo.A) precioBase += 100;
            else if (consumoEner == Consumo.B) precioBase += 80;
            else if (consumoEner == Consumo.C) precioBase += 60;
            else if (consumoEner == Consumo.D) precioBase += 50;
            else if (consumoEner == Consumo.E) precioBase += 30;
            else precioBase += 10;           
        }
        public void PrecioTamaño()
        {
            if (peso > 0 && peso < 20) precioBase += 10;
            else if (peso >= 20 && peso < 50) precioBase += 50;
            else if (peso >= 50 && peso < 80) precioBase += 80;
            else precioBase += 100;
        }
    }
}
