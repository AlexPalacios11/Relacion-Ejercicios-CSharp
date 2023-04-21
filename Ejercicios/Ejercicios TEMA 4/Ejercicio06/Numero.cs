namespace Ejercicio06;

public class Numero
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

	public static Numero operator ++(Numero n) => new Numero(n.entero + 1);
	public static Numero operator --(Numero n) => new Numero(n.entero - 1);
	public static Numero operator -(Numero n) => new Numero(-n.entero);


	public static Numero operator +(Numero n1, Numero n2) => new Numero(n1.entero + n2.entero);
	public static Numero operator -(Numero n1, Numero n2) => new Numero(n1.entero - n2.entero);
	public static Numero operator /(Numero n1, Numero n2) => new Numero(n1.entero / n2.entero);
	public static Numero operator *(Numero n1, Numero n2) => new Numero(n1.entero * n2.entero);


	public static bool operator ==(Numero n1, Numero n2)
	{
		bool result = false;

		if (ReferenceEquals(n1, null))
		{
			result = ReferenceEquals(n2, null);
		}
		else
			result = n1.Equals(n2);

		return result;
	}
	public static bool operator !=(Numero n1, Numero n2) => !(n1 == n2);

	public static bool operator <(Numero n1, Numero n2)
	{
		bool result = false;

		if (n1 == null)
			result = n2 != null;
		else if (n2 == null)
			result = false;
		else
			result = n1.entero < n2.entero;

		return result;
	}
	public static bool operator >(Numero n1, Numero n2)
	{
		bool result = false;

		if (n2 == null)
			result = n1 != null;
		else if (n1 == null)
			result = false;
		else result = n1.entero > n2.entero;

		return result;
	}
	public static bool operator >=(Numero numero1, Numero numero2) => !(numero1 < numero2);
	public static bool operator <=(Numero numero1, Numero numero2) => !(numero1 > numero2);

	public static implicit operator int(Numero n) => n?.entero ?? 0;
	public static explicit operator Numero(int n) => new Numero(n);

}
