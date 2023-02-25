using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio07
{
    internal class Videojuego
    {
        private const int HORAS_DEFAULT = 10;
        private const bool ENTREGADO_DEFAULT = false;

        private string titulo;
        private int horasEstimadas;
        private bool entregado;
        private string genero;
        private string compañia;

        public string Titulo { get => titulo;set=> titulo = value; }
        public int HorasEstimadas { get => horasEstimadas; set => horasEstimadas = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Compañia { get => compañia; set => compañia = value; }

        public  Videojuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            entregado = ENTREGADO_DEFAULT;
            this.genero = genero;
            this.compañia = compañia;
        }
        public Videojuego(string titulo, int horasEstimadas) : this (titulo, horasEstimadas, "", "")
        {
        }
        public Videojuego() : this ("", HORAS_DEFAULT)
        {
        }
        public override string ToString()
        {
            return $"Titulo: {titulo}\nHoras estimadas: {horasEstimadas}\nGenero: {genero}\nCompañia: {compañia}";
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
            Videojuego other = obj as Videojuego;

            if (other != null)
            {
                result = horasEstimadas.CompareTo(other.horasEstimadas);
            }

            return result;


        }
    }
}
