namespace Ejercicio06
{
    internal class CompactDisc
    {
        private Cancion[] canciones;
        private int contador;

        public int NumeroCanciones { get => contador; }

        public CompactDisc(int tamano)
        {
            canciones = new Cancion[tamano];
            contador = 0;
        }
        public Cancion ObtenerCancion(int posicion)
        {
            return canciones[posicion];
        }
        public void Agregar(Cancion cancion)
        {
            if (contador >= canciones.Length)
            {
                Console.WriteLine("Ya no entran más canciones");
            }
            else
            {
                canciones[contador] = cancion;
                contador++;
            }
        }
        public void Eliminar()
        {
            if (contador == 0) Console.WriteLine("No hay canciones que eliminar");
            else contador--;
        }
    }
}
