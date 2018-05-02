namespace P01_Database
{
    using System;
    using System.Linq;

    public class Database
    {
        private int[] data;
        private int count;

        public int Count => this.count;

        public Database()
        {
            this.data = new int[16];
        }

        public Database(params int[] numbers) : this()
        {
            if (numbers != null)
            {
                foreach (var number in numbers)
                {
                    this.Add(number);
                }
            }
        }

        public void Add(int number)
        {
            if (this.Count == this.data.Length)
            {
                throw new InvalidOperationException();
            }
            this.data[this.count++] = number;
        }

        public void Remove()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }
            this.count--;
        }

        public int[] Fetch()
        {
            return this.data.Take(this.count).ToArray();
        }
    }
}
