namespace Ejercicio09
{
    internal class Lista<T>
    {
        private const int CAPACIDAD_DEFAULT = 10;

        private T[] items;
        private int nextPosition;

        public int Capacity { get => items.Length; }
        public int Count { get => nextPosition; }

        public Lista(int capacidad) 
        { 
            items = new T[capacidad];
            nextPosition = 0;   
        }
        public Lista() : this (CAPACIDAD_DEFAULT)
        {
        }
        public T Get(int index)
        {
            return items[index];
        }
        public void Add(T item)
        {
            if (nextPosition >= items.Length)
            {
                T[] items2 = new T[items.Length * 2];   

                for (int i = 0; i < items.Length; i++)
                {
                    items2[i] = items[i];   
                }

                items = items2;
            }

            items[nextPosition] = item;
            nextPosition++;
        }
        public void Remove(T item)
        {
            int count = -1;
            
            for (int i = 0; count < 0 && i < items.Length; i++)
            {
                if (item == null)
                {
                    if (items[i] == null)
                    {
                        count = i;
                    }

                }
                else if (item.Equals(items[i]))
                {
                    count = i;
                }
            }

            if (count >= 0)
            {
                for (int i = count; i < nextPosition - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                nextPosition--;
            }
        }
        public override string ToString()
        {
            string result = "";
            int contador = 0;
            for (int i = 0; i < items.Length; i++)
            {

                if (i < nextPosition - 1)
                {
                    if (contador == 0)
                    {
                        result += items[i];
                        contador++;
                    }
                    else result += ", " + items[i];
                }
            }
            return "[" + result + "]";
        }

    }
}
