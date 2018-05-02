namespace P05_KingsGambitExtended.Models
{
    using P05_KingsGambitExtended.Contracts;
    using System;

    public abstract class Subordinate : ISubordinate
    {
        public event SubordinateDeathEventHandler DeathEvent;

        protected Subordinate(string name, string action, int hitpoints)
        {
            this.Name = name;
            this.Action = action;
            this.HitPoints = hitpoints;
            this.IsAlive = true;
        }

        public string Name { get; }

        public bool IsAlive { get; private set; }

        public string Action { get; }

        public int HitPoints { get; private set; }

        public void Die()
        {
            this.IsAlive = false;
            if (this.DeathEvent != null)
            { 
                this.DeathEvent.Invoke(this);
            }
        }

        public virtual void ReactToAttack()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"{this.GetType().Name} {this.Name} is {this.Action}!");
            }
        }

        public void TakeDamage()
        {
            this.HitPoints--;
            if (this.HitPoints <= 0)
            {
                this.Die();
            }
        }
    }
}
