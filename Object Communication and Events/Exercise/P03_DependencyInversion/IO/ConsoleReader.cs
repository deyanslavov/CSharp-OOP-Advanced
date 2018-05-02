namespace P03_DependencyInversion.IO
{
    using P03_DependencyInversion.Contracts;
    using System;

    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
