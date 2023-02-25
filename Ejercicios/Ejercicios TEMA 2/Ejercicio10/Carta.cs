namespace Ejercicio10
{
    internal class Carta<T> where T : Enum
    {
        private int numero;
        private T palo;

        public Carta(int numero, T palo)
        {
            this.numero = numero;
            this.palo = palo;
        }
        public int Numero { get => numero; }
        public T Palo { get => palo; }

        public override string ToString()
        {
            string nombre = string.Empty;

            switch(numero)
            {
                case 1:
                    nombre = "As";
                    break;
                case 10:
                    nombre = palo is PalosBarajaEspanola ? "Sota" : "Jota";
                    break;
                case 11:
                    nombre = palo is PalosBarajaEspanola ? "Caballo" : "Reina";
                    break;
                case 12:
                    nombre = "Rey";
                    break;
                default:
                    nombre = numero.ToString();
                    break;
            }
            return $"{nombre} de {palo}";
        }
    }
}

