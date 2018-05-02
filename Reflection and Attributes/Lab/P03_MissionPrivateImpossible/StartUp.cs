namespace P03_MissionPrivateImpossible
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var spy = new Spy();

            Console.WriteLine(spy.RevealPrivateMethods("Hacker"));
        }
    }
}
