namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[3];

            electrodomesticos[0] = new Electrodomestico(20, 40);
            electrodomesticos[1] = new Lavadora(90, 60);
            electrodomesticos[2] = new Television(10, 20);

            double precioElectrodomesticos = 0;
            double precioLavadoras = 0;
            double precioTelevisores = 0;

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                electrodomesticos[i].PrecioFinal();

                precioElectrodomesticos += electrodomesticos[i].PrecioBase;

                if (electrodomesticos[i] is Lavadora)
                    precioLavadoras += electrodomesticos[i].PrecioBase;
                else if (electrodomesticos[i] is Television)
                    precioTelevisores += electrodomesticos[i].PrecioBase;
            }

            Console.WriteLine($"Precio total electrodomesticos: {precioElectrodomesticos}");
            Console.WriteLine($"Precio total lavadoras: {precioLavadoras}");
            Console.WriteLine($"Precio total televisores: {precioTelevisores}");
        }
    }
}