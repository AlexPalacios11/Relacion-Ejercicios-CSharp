namespace Ejercicio2;

public class PeriodicoFuncAction : Periodico
{
    public event Action<Noticia> NoticiaPublicada;

    protected override void Notificar(Noticia noticia)
    {
        NoticiaPublicada?.Invoke(noticia);
    }
}
