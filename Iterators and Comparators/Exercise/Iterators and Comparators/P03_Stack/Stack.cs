﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private List<T> data;

    public Stack()
    {
        this.data = new List<T>();
    }

    public void Push(T[] args)
    {
        foreach (var arg in args)
        {
            this.data.Add(arg);
        }
    }

    public string Pop()
    {
        if (this.data.Count == 0)
        {
            return "No elements";
        }
        var element = this.data.Last();
        this.data.Remove(element);
        return null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.data.Count - 1; i >= 0; i--)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = this.data.Count - 1; i >= 0; i--)
        {
            yield return this.data[i];
        }
    }
}

