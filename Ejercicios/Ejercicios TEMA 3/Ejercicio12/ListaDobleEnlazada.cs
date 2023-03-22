using System.Collections;

namespace Ejercicio12;

class ListaDobleEnlazada<T> : IEnumerable<T>
{
    private class Nodo
    {
        public T Value { get; set; }
        public Nodo Next { get; set; }
        public Nodo Previous { get; set; }
    }

    private Nodo _head;
    private int _size;

    public int Count => _size;

    public ListaDobleEnlazada() { }

    public ListaDobleEnlazada(IEnumerable<T> items)
    {
        foreach (T item in items) Add(item);
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public void Add(T item)
    {
        Nodo nodo = new Nodo()
        {
            Value = item
        };

        // Si la cabeza es nula pues ahora el nodo creado es la cabeza
        // Como solo hay un nodod, ese mismo nodo es el anterior y siguiente del mismo
        if (_head == null)
        {
            _head = nodo;
            nodo.Next = _head;
            nodo.Previous = _head;
        }
        // Si hay elementos, pues añado el nodo creado al final de la lista
        // Entonces, el siguiente del anterior de la cabecera pasará a ser el nuevo nodo,
        // el anterior del nuevo nodo será el anterior de la cabecera,
        // el siguiente del nuevo nodo será la cabecera y
        // el anterior de la cabecera será el nuevo nodo
        else
        {
            nodo.Previous = _head.Previous;
            nodo.Next = _head;
            _head.Previous.Next = nodo;
            _head.Previous = nodo;
        }

        _size++;
    }

    public void Remove(T item)
    {
        if (_head != null)
        {
            Nodo current = _head;
            int count = 0;
            bool found = false;

            while (count < Count && !found)
            {
                if (item == null)
                    found = _head.Value == null;
                else
                    found = item.Equals(current.Value);

                count++;
                // Si lo he encontrado no avanzo
                if (!found) current = current.Next;
            }

            if (found)
            {
                // Si lo que se borra es la cabecera tenemos que actualizar su valor
                if (current == _head)
                {
                    // Si solo hay un elemento entonces la cabecera es nula
                    if (_size == 1)
                        _head = null;
                    // Si no, entonces la cabecera será el siguiente en la lista
                    else
                        _head = _head.Next;
                }

                // A la hora de borrar, el siguiente del anterior del que se va a borrar va a ser el siguiente de este
                // y el anterior del siguiente del que se va a borrar va a ser el anterior
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;

                _size--;
            }
        }
    }

    public bool Contains(T item)
    {
        bool result = false;
        Nodo current = _head;
        int count = 0;

        while (count < Count && !result)
        {
            if (item == null)
                result = current.Value == null;
            else
                result = item.Equals(current.Value);

            count++;
            current = current.Next;
        }

        return result;
    }

    public void Clear()
    {
        _head = null;
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
        private ListaDobleEnlazada<T> _lista;
        private Nodo _currentNode;
        private int _count;

        public T Current { get; private set; }
        object IEnumerator.Current => Current;

        public Enumerator(ListaDobleEnlazada<T> lista)
        {
            _lista = lista;
            Reset();
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            bool result = _count < _lista.Count;

            if (result)
            {
                Current = _currentNode.Value;
                _currentNode = _currentNode.Next;
                _count++;
            }

            return result;
        }

        public void Reset()
        {
            _currentNode = _lista._head;
            _count = 0;
        }
    }
}
