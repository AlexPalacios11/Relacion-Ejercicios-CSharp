namespace Ejercicio07
{
    interface IEntregable : IComparable
    {
        public void Entregar();
        public void Devolver();
        public bool EsEntregado();
    }
}
