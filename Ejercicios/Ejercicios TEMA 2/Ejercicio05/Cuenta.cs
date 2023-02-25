namespace Ejercicio05
{
    internal class Cuenta
    {
        private Persona titular;
        private double cantidad;

        public Persona Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }    

        public Cuenta(Persona titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public Cuenta(Persona titular) : this (titular, 0)
        {
        }
        public override string ToString()
        {
            return $"Titular: {titular}\nCantidad: {cantidad}";
        }
        public void Ingresar(double cantidad)
        {
            if(cantidad > 0) this.cantidad += cantidad;
        }
        public virtual void Retirar(double cantidad)
        {
            this.cantidad -= cantidad;
        }
    }
}
