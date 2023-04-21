namespace Ejercicio2;

public class PeriodicoEventHandler : Periodico
{
    public class NoticiaPublicadaEventArgs : EventArgs
    {
        public Noticia Noticia { get; set; }
    }

    public delegate void NoticiaPublicadaEventHandler(object sender, NoticiaPublicadaEventArgs e);

    public event NoticiaPublicadaEventHandler NoticiaPublicada;

    protected override void Notificar(Noticia noticia)
    {
        NoticiaPublicada?.Invoke(this, new NoticiaPublicadaEventArgs() { Noticia = noticia });
    }
}
