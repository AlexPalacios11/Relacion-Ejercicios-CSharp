namespace Ejercicio05;

public struct Numero
{
	private int? entero;

	public Numero(int? entero)
	{
		this.entero = entero;
	}
	public override string ToString()
	{
		return entero.ToString();
	}

	public static Numero operator ++(Numero numero) => new Numero(numero.entero + 1); 
	public static Numero operator --(Numero numero) => new Numero(numero.entero - 1);
	public static Numero operator -(Numero numero) => new Numero(-numero.entero);

	public static Numero operator +(Numero numero1, Numero numero2) => new Numero(numero1.entero + numero2.entero);
	public static Numero operator -(Numero numero1, Numero numero2) => new Numero(numero1.entero - numero2.entero);
	public static Numero operator *(Numero numero1, Numero numero2) => new Numero(numero1.entero * numero2.entero);
	public static Numero operator /(Numero numero1, Numero numero2) => new Numero(numero1.entero / numero2.entero);


	public static bool operator ==(Numero numero1, Numero numero2) => numero1.Equals(numero2);
	public static bool operator !=(Numero numero1, Numero numero2) => !numero1.Equals(numero2);
	public static bool operator <(Numero numero1, Numero numero2) => numero1.entero < numero2.entero;
	public static bool operator >(Numero numero1, Numero numero2) => numero1.entero > numero2.entero;
	public static bool operator >=(Numero numero1, Numero numero2)=> numero1.entero >= numero2.entero;
	public static bool operator <=(Numero numero1, Numero numero2) => numero1.entero <= numero2.entero;



	public static implicit operator int(Numero numero) => numero.entero.GetValueOrDefault();

	public static explicit operator Numero(int numero) => new Numero(numero);

}
