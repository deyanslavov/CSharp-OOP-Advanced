using System;
using System.Collections.Generic;

public class ListyIterator<T>
{
    private readonly List<T> data;
    private int currentIndex;

    public ListyIterator(params T[] data)
    {
        this.data = new List<T>(data);
        this.currentIndex = 0;
    }

    public bool Move()
    {
        if (this.currentIndex + 1 < this.data.Count)
        {
            this.currentIndex++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print()
    {
        if (this.data.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(this.data[this.currentIndex]);
    }

    public bool HasNext()
    {
        if (this.currentIndex == this.data.Count - 1)
        {
            return false;
        }
        return true;
    }
}

