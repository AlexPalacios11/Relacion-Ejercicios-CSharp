namespace Ejercicio2;

public class PersonaEventHandler : Persona
{
    public PersonaEventHandler(PeriodicoEventHandler periodico, Temas[] temas) : base(temas)
    {
        periodico.NoticiaPublicada += OnNoticiaPublicada;
    }

    private void OnNoticiaPublicada(object sender, PeriodicoEventHandler.NoticiaPublicadaEventArgs e)
    {
        RecibirNoticia(e.Noticia);
    }
}
