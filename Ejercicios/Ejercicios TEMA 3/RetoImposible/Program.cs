
        // Crea un rango de números de 1 a la altura del diamante ingresada por el usuario,
        // utilizando la función TryParse para convertir el valor ingresado a un número entero. 
        // Si TryParse falla, se utiliza 0 como valor predeterminado para la altura.
        Enumerable.Range(1, int.TryParse(Console.ReadLine(), out int input) ? input : 0)

        // Concatena un segundo rango de números de 1 a la altura del diamante menos 1,
        // invertido con la función Reverse(), para formar el diamante completo. 
        .Concat(Enumerable.Range(1, input - 1).Reverse())

        // Para cada número en el rango anterior, crea una cadena que consiste en
        // una cantidad de espacios igual a la diferencia entre la altura y el número,
        // seguida de una cantidad de asteriscos igual a dos veces el número menos 1.
        .Select(x => new string(' ', input - x) + new string('*', 2 * x - 1))

        // Convierte el resultado anterior en una lista y llama al método ForEach(),
        // que toma una acción para ejecutar en cada elemento de la lista. En este caso,
        // la acción es imprimir cada elemento en la consola.
        .ToList().ForEach(Console.WriteLine);