namespace P05_KingsGambitExtended
{
    using P05_KingsGambitExtended.Contracts;
    using System;
    using System.Linq;

    public class Engine
    {
        private IKing king;

        public Engine(IKing king)
        {
            this.king = king;
        }

        public void Run()
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "Attack")
                {
                    king.ReceiveAttack();
                }
                else
                {
                    string subordinateName = tokens[1];
                    ISubordinate subordinate = king.Subordinates.First(s => s.Name == subordinateName);
                    subordinate.TakeDamage();
                }
            }
        }
    }
}