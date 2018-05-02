namespace P03_ListIterator
{
    using System;
    using System.Collections.Generic;

    public class ListIterator
    {
        private IList<string> data;
        private int currentIndex;

        public ListIterator(IEnumerable<string> data)
        {
            this.data = (List<string>)data ?? throw new ArgumentNullException();
        }

        public int Count => this.data.Count;

        public int CurrentIndex => this.currentIndex;

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

        public bool HasNext()
        {
            if (this.currentIndex == this.data.Count - 1)
            {
                return false;
            }
            return true;
        }

        public string Print()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return this.data[this.currentIndex];
        }
    }
}