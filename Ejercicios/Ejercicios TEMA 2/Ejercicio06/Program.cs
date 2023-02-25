namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Take on me", "A-ha");
            Cancion cancion2 = new Cancion("Africa","Toto");
            Cancion cancion3 = new Cancion("Don't stop believin", "Journey");

            CompactDisc CD = new CompactDisc(2);
            CD.Agregar(cancion1);
            Console.WriteLine(CD.NumeroCanciones);
            CD.Eliminar();
            Console.WriteLine(CD.NumeroCanciones);
            CD.Agregar(cancion1);
            CD.Agregar(cancion2);
            CD.Agregar(cancion3);
            Console.WriteLine(CD.NumeroCanciones);
            Cancion cancion = CD.ObtenerCancion(0);
            Console.WriteLine($"{cancion.Titulo} de {cancion.Autor}");
        }
    }
}