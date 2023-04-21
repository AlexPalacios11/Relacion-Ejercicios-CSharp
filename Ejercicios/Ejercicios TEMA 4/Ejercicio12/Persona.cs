namespace Ejercicio12;

class Persona
{
	private string _nombre;
	private int _edad;

	public string Nombre { get => _nombre; }
	public int Edad { get => _edad; }

	public Persona(string nombre, int edad)
	{
		_nombre = nombre;
		_edad = edad;
	}
	public int AmpliarEdad() => _edad++;
	private string Concatenar() => $"Nombre: {_nombre}, Edad: {_edad}";
}
