namespace Ejercicio2;

public class PersonaFuncAction : Persona
{
    public PersonaFuncAction(PeriodicoFuncAction periodico, Temas[] temas) : base(temas)
    {
        periodico.NoticiaPublicada += OnNoticiaPublicada;
    }

    private void OnNoticiaPublicada(Noticia noticia)
    {
        RecibirNoticia(noticia);
    }
}
