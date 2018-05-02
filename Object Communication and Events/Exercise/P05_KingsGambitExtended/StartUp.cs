namespace P05_KingsGambitExtended
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Models;

    class StartUp
    {
        static void Main()
        {
            IKing king = SetUpKing();

            Engine engine = new Engine(king);
            engine.Run();
        }

        private static IKing SetUpKing()
        {
            string kingName = Console.ReadLine();
            IKing king = new King(kingName, new List<ISubordinate>());

            string[] royalGuardNames = Console.ReadLine().Split();

            foreach (var name in royalGuardNames)
            {
                king.AddSubordinate(new RoyalGuard(name));
            }

            string[] footmenNames = Console.ReadLine().Split();

            foreach (var name in footmenNames)
            {
                king.AddSubordinate(new Footman(name));
            }

            return king;
        }

    }
}
