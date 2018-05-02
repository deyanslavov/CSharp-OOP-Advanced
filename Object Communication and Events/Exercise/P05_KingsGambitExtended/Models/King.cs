namespace P05_KingsGambitExtended.Models
{
    using System;
    using System.Collections.Generic;
    using P05_KingsGambitExtended.Contracts;

    public class King : IKing
    {
        public event GetAttackedEventHandler GetAttackedEvent;

        private ICollection<ISubordinate> subordinates;

        public King(string name, ICollection<ISubordinate> subordinates)
        {
            this.Name = name;
            this.subordinates = subordinates;
        }

        public string Name { get;  }

        public IReadOnlyCollection<ISubordinate> Subordinates => (IReadOnlyCollection<ISubordinate>)this.subordinates;
        
        public void ReceiveAttack()
        {
            Console.WriteLine($"{this.GetType().Name} {this.Name} is under attack!");
            if (this.GetAttackedEvent != null)
            {
                this.GetAttackedEvent.Invoke();
            }
        }

        public void AddSubordinate(ISubordinate subordinate)
        {
            this.subordinates.Add(subordinate);
            this.GetAttackedEvent += subordinate.ReactToAttack;
            subordinate.DeathEvent += this.OnSubordinateDeath;
        }

        public void OnSubordinateDeath(object sender)
        {
            this.subordinates.Remove((ISubordinate)sender);
        }
    }
}
