using System.Collections.Generic;
using System.Linq;

public class PersonNameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);
        if (result == 0)
        {
            result = x.Name.First().ToString().ToLowerInvariant().CompareTo(y.Name.First().ToString().ToLowerInvariant());
        }
        return result;
    }
}
