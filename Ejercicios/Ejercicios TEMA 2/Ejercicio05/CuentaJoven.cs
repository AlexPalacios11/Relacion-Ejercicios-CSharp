namespace Ejercicio05
{
    internal class CuentaJoven : Cuenta
    {
        private const int EDAD_MINIMA_CUENTA_JOVEN = 25;

        private double bonificacion;

        public double Bonificacion { get => bonificacion; set => bonificacion = value; }    

        public CuentaJoven(double bonificacion, Persona titular, double cantidad) : base (titular, cantidad)
        {
            this.bonificacion = bonificacion;
        }
        public CuentaJoven(double bonificacion, Persona titular) : this (bonificacion, titular, 0)
        {
        }
        public bool EsTitularValido()
        {
            return Titular.EsMayorDeEdad() && Titular.Edad < EDAD_MINIMA_CUENTA_JOVEN;
        }
        public override void Retirar(double cantidad)
        {
            if (EsTitularValido()) base.Retirar(cantidad);
        }
        public override string ToString()
        {
            return $"CUENTA JOVÉN\nBonificación de la cuenta: {bonificacion} %\n" + base.ToString();
        }
    }
}
