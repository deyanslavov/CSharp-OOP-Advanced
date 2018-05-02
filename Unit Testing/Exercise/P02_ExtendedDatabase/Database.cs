namespace P02_ExtendedDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private HashSet<Person> people;

        public int Count => this.people.Count;

        public Database()
        {
            this.people = new HashSet<Person>();
        }

        public Database(IEnumerable<Person> people) : this()
        {
            if (people != null)
            {
                foreach (var number in people)
                {
                    this.Add(number);
                }
            }
        }

        public void Add(Person person)
        {
            if (this.people.Any(p => p.Id == person.Id || p.Username == person.Username))
            {
                throw new InvalidOperationException();
            }
            this.people.Add(person);
        }

        public void Remove(Person person)
        {
            this.people.RemoveWhere(p => p.Id == person.Id && p.Username == person.Username);
        }

        public Person Find(long id)
        {
            if (!this.people.Any(p => p.Id == id))
            {
                throw new InvalidOperationException();
            }
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.people.First(p => p.Id == id);
        }

        public Person Find(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException();
            }
            if (!this.people.Any(p => p.Username == username))
            {
                throw new InvalidOperationException();
            }
            return this.people.First(p => p.Username == username);
        }
    }
}