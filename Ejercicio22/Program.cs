namespace Ejercicio22
{
    class Program
    {
        enum State { On, Off };
        public static void Main()
        {
            State state = State.Off;
            while (true)
            {
                Console.WriteLine("El estado actual es {0}", state);
                Console.Write("Introduce una acción: ");
                try
                {
                    string input = Console.ReadLine();
                }
                catch (Exception a)
                {
                    throw new Exception (Console.Write(a));
                }
                string input = Console.ReadLine();
                State action = (State)Enum.Parse(typeof(State), input, true);

                if (state == State.On && action == State.Off)
                {
                    state = State.Off;
                }
                else if (state == State.Off && action == State.On)
                {
                    state = State.On;
                }
                else
                {
                    throw new Exception("Acción no válida");
                }
            }

        }
    }
}