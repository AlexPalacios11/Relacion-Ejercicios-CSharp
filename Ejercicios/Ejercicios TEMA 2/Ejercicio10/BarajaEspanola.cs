namespace Ejercicio10;

internal class BarajaEspanola : Baraja<PalosBarajaEspanola>
{
    private const int CARTAS_POR_PALO = 10;
    private const int CARTAS_POR_PALO_EXTENDIDA = 12;

    private bool extendida;

    public BarajaEspanola(bool extendida)
    {
        this.extendida = extendida;
        CrearBaraja();
    }
    public override void CrearBaraja()
    {
        int numeroPalos = Enum.GetValues<PalosBarajaEspanola>().Length;
        cartasPorPalo = extendida ? CARTAS_POR_PALO_EXTENDIDA : CARTAS_POR_PALO;
        numeroCartas = cartasPorPalo * numeroPalos;
        cartas = new Carta<PalosBarajaEspanola>[numeroCartas];

        for (int numeroPalo = 0; numeroPalo < numeroPalos; numeroPalo++)
        {
            PalosBarajaEspanola palo = (PalosBarajaEspanola)numeroPalo;

            for (int numero = 1; numero <= CARTAS_POR_PALO_EXTENDIDA; numero++)
            {
                if (extendida || numero < 8 || numero > 9)
                {
                    int posicion = numero - 1 + numeroPalo * cartasPorPalo;
                    if (!extendida && numero > 7) posicion -= 2;
                    cartas[posicion] = new Carta<PalosBarajaEspanola>(numero, palo);
                }
            }
        }
    }
}
