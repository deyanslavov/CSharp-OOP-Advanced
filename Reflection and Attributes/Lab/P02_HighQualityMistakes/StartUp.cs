using System;

namespace P02_HighQualityMistakes
{
    class StartUp
    {
        static void Main()
        {
            var spy = new Spy();
            Console.WriteLine(spy.AnalyzeAcessModifiers("Hacker"));
        }
    }
}
