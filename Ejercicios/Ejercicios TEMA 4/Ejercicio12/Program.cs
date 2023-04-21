using System.Reflection;

namespace Ejercicio12;

internal class Program
{
	static void Main(string[] args)
	{
        Assembly assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine(assembly);
        Console.WriteLine();

        //_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        Type personaType = typeof(Persona);

        foreach (FieldInfo field in personaType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
        {
            Console.WriteLine($"{field.Name} -- {field.FieldType}");
        }
        Console.WriteLine();

        //_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        foreach (PropertyInfo property in personaType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            Console.WriteLine($"{property.Name} -- {property.PropertyType}");
        }
        Console.WriteLine();

        //_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        foreach (ConstructorInfo constructor in personaType.GetConstructors(BindingFlags.Instance | BindingFlags.Public))
        {
            Console.WriteLine($"{constructor.Name}  {string.Join<ParameterInfo>(", ", constructor.GetParameters())}");
        }
        Console.WriteLine();

        //_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        foreach (MethodInfo method in personaType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
        {
            Console.WriteLine($"{method.Name} TYPE: {string.Join<ParameterInfo>(", ", method.GetParameters())} RETURN: {method.ReturnType}");
        }
        Console.WriteLine();

        //_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        object person = Activator.CreateInstance(personaType, "hola", 47 );
        MethodInfo methodPerson = personaType.GetMethod("AmpliarEdad");
		methodPerson.Invoke(person, null);

        foreach (PropertyInfo proper in personaType.GetProperties())
        {
            Console.WriteLine($"{proper.Name} = {proper.GetValue(person)}");
        }
        

    }
}