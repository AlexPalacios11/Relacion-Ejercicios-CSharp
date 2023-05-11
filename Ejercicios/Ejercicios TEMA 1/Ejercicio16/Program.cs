int @base;
bool isCorrect;

do
{
    Console.WriteLine("Introduce la base:");
    @base = int.Parse(Console.ReadLine());

    isCorrect = @base >= 2 && @base <= 9;

    if (!isCorrect)
        Console.WriteLine("La base no puede ser menor que 2 ni mayor que 9");

} while (!isCorrect);

Console.WriteLine("Introduce el número:");
int number = int.Parse(Console.ReadLine());

int quotient = number, remainder;
string result = "";

while (quotient != 0)
{
    remainder = quotient % @base;
    quotient = quotient / @base; // Es igual a quotient /= @base

    result = result + remainder; // Es igual a result += remainder
}

for (int i = result.Length - 1; i >= 0; i--)
{
    Console.Write(result[i]);
}

