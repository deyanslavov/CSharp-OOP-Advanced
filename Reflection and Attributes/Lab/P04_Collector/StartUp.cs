namespace P04_Collector
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var spy = new Spy();

            Console.WriteLine(spy.CollectGettersAndSetters("Hacker"));
        }
    }
}
