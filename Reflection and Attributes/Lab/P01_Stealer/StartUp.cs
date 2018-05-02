using System;

namespace P01_Stealer
{
    class StartUp
    {
        static void Main()
        {
            var spy = new Spy();

            Console.WriteLine(spy.StealFieldInfo("Hacker", "username", "password"));
        }
    }
}
