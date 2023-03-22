using System.Collections;

namespace Ejercicio11;

public class Pila<T> : IEnumerable<T>
{
    private class Nodo
    {
        public T Value { get; set; }
        public Nodo Next { get; set; }
    }

    private Nodo _top;
    private int _size;

    public int Count => _size;

    public Pila()
    {
        _size = 0;
    }

    public Pila(IEnumerable<T> items) : this()
    {
        foreach (T item in items)
            Push(item);
    }

    public void Push(T item)
    {
        Nodo nodo = new Nodo()
        {
            Value = item
        };

        nodo.Next = _top;
        _top = nodo;
        _size++;
    }

    public T Pop()
    {
        T result = Peek();

        _top = _top.Next;
        _size--;

        return result;
    }

    public T Peek()
    {
        if (_top == null)
            throw new InvalidOperationException();

        return _top.Value;
    }

    public bool Contains(T item)
    {
        bool result = false;

        Nodo current = _top;

        while (current != null && !result)
        {
            if (item == null)
                result = current.Value == null;
            else
                result = item.Equals(current.Value);

            current = current.Next;
        }

        return result;
    }

    public void Clear()
    {
        _top = null;
        _size = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new Enumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class Enumerator : IEnumerator<T>
    {
        private Pila<T> _pila;
        private Nodo _currentNode;

        public T Current { get; private set; }
        object IEnumerator.Current => Current;

        public Enumerator(Pila<T> pila)
        {
            _pila = pila;
            Reset();
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            bool result = _currentNode != null;

            if (result)
            {
                Current = _currentNode.Value;
                _currentNode = _currentNode.Next;
            }

            return result;
        }

        public void Reset()
        {
            _currentNode = _pila._top;
        }
    }
}
