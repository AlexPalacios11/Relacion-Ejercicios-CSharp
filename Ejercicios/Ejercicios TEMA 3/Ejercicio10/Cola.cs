using System;
using System.Collections;

namespace Ejercicio10;

class Cola<T> : IEnumerable<T>
{
    private T[] array;
    private int count;
    // propiedad de lectura pública que devuelve la cantidad de elementos en la cola
    public int Count { get => count; }
    // constructor que recibe una colección por parámetro y la añade a la cola
    public Cola(IEnumerable<T> collection)
    {
        array = new T[collection.Count()];
        count = 0;
        foreach (T item in collection)
        {
            Enqueue(item);
        }
    }
    // constructor por defecto con tamaño inicial de 10
    public Cola()
    {
        array = new T[10];
        count = 0;
    }

    // método que indica si la cola está vacía
    public bool IsEmpty()
    {
        return count == 0;
    }
    // método que añade un elemento a la cola
    public void Enqueue(T item)
    {
        if (count == array.Length)
        {
            T[] newArray = new T[array.Length * 2];
            Array.Copy(array, 0, newArray, 0, count);
            array = newArray;
        }
        array[count] = item;
        count++;
    }
    // método que elimina y devuelve el primer elemento de la cola
    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }
        T item = array[0];
        for (int i = 0; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }
        count--;
        return item;
    }
    // método que devuelve el primer elemento de la cola sin eliminarlo
    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }
        return array[0];
    }
    // método que indica si un elemento está en la cola
    public bool Contains(T item)
    {
        bool result = false;

        for (int i = 0; i < count && !result; i++)
        {
            if (item == null)
                result = array[i] == null;
            else
                result = item.Equals(array[i]);
        }
        return result;
    }
    // método que elimina todos los elementos de la cola
    public void Clear()
    {
        count = 0;
    }
    // implementación de la interfaz IEnumerable<T>
    public IEnumerator<T> GetEnumerator()
    {
        return new ColaEnumerator(this);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    private class ColaEnumerator : IEnumerator<T>
    {
        private Cola<T> cola;
        private int index;
        public T Current => cola.array[index];
        object IEnumerator.Current => Current;
        public ColaEnumerator(Cola<T> cola)
        {
            this.cola = cola;
            index = -1;
        }
        public void Dispose()
        {
        }
        public bool MoveNext()
        {
            index++;
            return index < cola.count;
        }
        public void Reset()
        {
            index = -1;
        }
    }
}