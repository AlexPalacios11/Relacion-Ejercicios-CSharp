using System.Collections;

namespace Ejercicio13;

class Conjunto<T> : IEnumerable<T>
{
    private List<T> _list;

    public int Count => _list.Count;

    public Conjunto()
    {
        _list = new List<T>();
    }

    public Conjunto(IEnumerable<T> items) : this()
    {
        foreach (T item in items)
            Add(item);
    }

    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    public void Add(T item)
    {
        if (!_list.Contains(item))
            _list.Add(item);
    }

    public void Remove(T item)
    {
        _list.Remove(item);
    }

    public bool Contains(T item)
    {
        return _list.Contains(item);
    }

    public void Clear()
    {
        _list.Clear();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
