namespace Ejercicio2;

public interface IObservable
{
    void Suscribir(IObservador observador);
    void Desuscribir(IObservador observador);
}
