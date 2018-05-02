using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Lake : IEnumerable<int>
{
    private List<int> stones;

    public Lake(List<int> stones)
    {
        this.stones = stones;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.stones.Count; i+=2)
        {
            yield return this.stones[i];
        }

        if (this.stones.Count % 2 == 1)
        {
            for (int i = this.stones.Count - 2; i >= 0; i-=2)
            {
                yield return this.stones[i];
            }
        }
        else
        {
            for (int i = this.stones.Count - 1; i >= 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var stone in this.stones.Where(s => s % 2 == 1).OrderBy(a => a))
        {
            yield return stone;
        }

        foreach (var stone in this.stones.Where(s => s % 2 == 0).OrderByDescending(a => a))
        {
            yield return stone;
        }
    }
}

