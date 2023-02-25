namespace Ejercicio06
{
    internal class Cancion
    {
        private string titulo;
        private string autor;

        public string Titulo { get => titulo; }
        public string Autor { get => autor; }

        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }   
    }
}
