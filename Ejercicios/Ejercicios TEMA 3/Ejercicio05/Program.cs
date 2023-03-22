namespace Ejercicio05;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        { {"casa", "Edificio para habitar"},
          {"pelota", "Bola hecha de una materia que le permita botar, usada en diversos juegos y deportes"},
          {"tenedor", "Instrumento de mesa en forma de horca, con dos o más púas y que sirve para comer alimentos sólidos"},
          {"baloncesto", "Juego entre dos equipos de cinco jugadores cada uno, cuyo objetivo es introducir el balón en la cesta o canasta del contrario, situada a una altura determinada"},
          {"manzana", "Fruto del manzano, de forma globosa algo hundida por los extremos del eje, de epicarpio delgado, liso y de color verde claro, amarillo pálido o encarnado, mesocarpio con sabor acídulo o ligeramente azucarado, y semillas pequeñas, de color de caoba, encerradas en un endocarpio coriáceo"}
        };

        Console.Write("Escriba una palabra para obtener la definición: ");
        string userWord = Console.ReadLine();
        Console.WriteLine();

        if (dic.TryGetValue(userWord, out string value))
        {
            Console.WriteLine(value);
        }
        else Console.WriteLine("No existe la palabra en el diccionario");        
    }
}