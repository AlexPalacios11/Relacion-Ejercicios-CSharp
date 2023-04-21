namespace Ejercicio2;

public class Noticia
{
    public Temas Tema { get; private set; }

    public Noticia(Temas tema)
    {
        Tema = tema;
    }
}
