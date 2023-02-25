namespace Ejercicio11
{
    class Jugador
    {
        private const int DISTANCIA_MINIMA = 5;

        private Vector3 posicion;
        private bool estaVivo;

        public bool EstaVivo { get => estaVivo; }

        public Jugador(Vector3 posicion)
        {
            this.posicion = posicion;
            estaVivo = true;
        }
        public Jugador() : this(new Vector3())
        {
        }
        public void Mover(Vector3 vector)
        {
            posicion = posicion.Sumar(vector);
        }
        public void Matar(Jugador jugador)
        {
            if (posicion.Distancia(jugador.posicion) < DISTANCIA_MINIMA) estaVivo = false;
        }
    }
}
