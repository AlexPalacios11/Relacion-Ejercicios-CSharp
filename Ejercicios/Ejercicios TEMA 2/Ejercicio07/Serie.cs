namespace Ejercicio07
{
    internal class Serie : IEntregable
    {
        private const int NUMERO_TEMPORADAS_DEFAULT = 3;
        private const bool ENTREGADO_DEFAULT = false; 

        private string titulo;
        private int numeroTemporadas;
        private bool entregado;
        private string genero;
        private string creador;
        
        public string Titulo { get => titulo; set => titulo = value; }
        public int NumeroTemporadas { get => numeroTemporadas; set => numeroTemporadas = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            entregado = ENTREGADO_DEFAULT;
            this.genero = genero;   
            this.creador = creador;
        }
        public Serie(string titulo, string creador) : this (titulo, NUMERO_TEMPORADAS_DEFAULT, "", creador)
        {
        }
        public Serie() : this ("", "")
        {
        }
        public override string ToString()
        {
            return $"Titulo: {titulo}\nNumero de temporadas: {numeroTemporadas}\nEntregado: {entregado}\nGenero: {genero}\nCreador: {creador}";
        }
        public void Entregar()
        {
            entregado = true;
        }
        public void Devolver()
        {
            entregado = false;
        }
        public bool EsEntregado()
        {
            return entregado;
        }
        public int CompareTo(object obj)
        {
            int result = 1;
            Serie other = obj as Serie;

            if (other != null)
            {
                result = numeroTemporadas.CompareTo(other.numeroTemporadas);
            }

            return result;
        }

    }
}
