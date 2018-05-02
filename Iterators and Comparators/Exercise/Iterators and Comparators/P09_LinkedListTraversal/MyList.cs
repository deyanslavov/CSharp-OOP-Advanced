using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IEnumerable<T>
{
    private List<T> data = new List<T>();

    public int Count => this.data.Count;

    public void Add(T item)
    {
        this.data.Add(item);
    }

    public bool Remove(T item)
    {
        return this.data.Remove(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
