namespace P07_EqualityLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var sortedSetPeople = new SortedSet<Person>();
            var hasSetPeople = new HashSet<Person>();

            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var personInput = Console.ReadLine().Split();
                var person = new Person(personInput[0], int.Parse(personInput[1]));

                sortedSetPeople.Add(person);

                if (!hasSetPeople.Any(p => p.Equals(person) || p.GetHashCode() == person.GetHashCode()))
                {
                    hasSetPeople.Add(person);
                }
            }

            Console.WriteLine(sortedSetPeople.Count + Environment.NewLine + hasSetPeople.Count);
        }
    }
}
