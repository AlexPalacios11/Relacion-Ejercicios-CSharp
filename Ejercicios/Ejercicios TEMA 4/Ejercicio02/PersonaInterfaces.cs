namespace Ejercicio2;

public class PersonaInterfaces : Persona, IObservador
{
    public PersonaInterfaces(Temas[] temas) : base(temas)
    {
    }

    public void Notificar(string nombreEvento, object valorEvento)
    {
        if (nombreEvento == "Publicación")
        {
            RecibirNoticia((Noticia)valorEvento);
        }
    }
}
