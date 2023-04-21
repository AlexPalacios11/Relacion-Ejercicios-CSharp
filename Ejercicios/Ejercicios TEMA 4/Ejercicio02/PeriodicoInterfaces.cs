namespace Ejercicio2;

public class PeriodicoInterfaces : Periodico, IObservable
{
    private List<IObservador> observadores = new List<IObservador>();

    public void Desuscribir(IObservador observador)
    {
        observadores.Remove(observador);
    }

    public void Suscribir(IObservador observador)
    {
        if (!observadores.Contains(observador))
            observadores.Add(observador);
    }

    protected override void Notificar(Noticia noticia)
    {
        foreach (IObservador observador in observadores)
        {
            observador.Notificar("Publicación", noticia);
        }
    }
}
