namespace P05_ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var tokens = line.Split();

                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }

            int personIndexToCompare = int.Parse(Console.ReadLine()) - 1;

            int numberOfEqualPpl = 0;
            int numberOfNotEqualPpl = 0;

            foreach (var person in people.Where(p => p != people[personIndexToCompare]))
            {
                if (people[personIndexToCompare].CompareTo(person) == 0)
                {
                    numberOfEqualPpl++;
                }
                else
                {
                    numberOfNotEqualPpl++;
                }
            }
            if (numberOfEqualPpl == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfEqualPpl+1} {numberOfNotEqualPpl} {people.Count}");
            }
        }
    }
}
