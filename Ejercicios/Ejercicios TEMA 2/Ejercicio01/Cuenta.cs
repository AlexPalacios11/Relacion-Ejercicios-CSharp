namespace Ejercicio01
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public Cuenta(string titular) : this(titular, 0)
        {
        }
        public override string ToString()
        {
            return $"Titular de la cuenta: {titular}\nCantidad en la cuenta: {cantidad}\n";
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad <= 0) { }
            else this.cantidad += cantidad;
        }
        public void Retirar(double cantidad)
        {
            this.cantidad -= cantidad;

            if (this.cantidad < 0) this.cantidad = 0;        
        }

    }
}
