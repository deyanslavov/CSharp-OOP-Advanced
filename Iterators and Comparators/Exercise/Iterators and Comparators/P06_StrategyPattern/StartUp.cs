namespace P06_StrategyPattern
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            SortedSet<Person> sortedPeopleByName = new SortedSet<Person>(new PersonNameComparator());
            SortedSet<Person> sortedPeopleByAge = new SortedSet<Person>(new PersonAgeComparator());

            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var personInput = Console.ReadLine().Split();
                var person = new Person(personInput[0], int.Parse(personInput[1]));

                sortedPeopleByAge.Add(person);
                sortedPeopleByName.Add(person);
            }

            foreach (var person in sortedPeopleByName)
            {
                Console.WriteLine(person);
            }
            foreach (var person in sortedPeopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
