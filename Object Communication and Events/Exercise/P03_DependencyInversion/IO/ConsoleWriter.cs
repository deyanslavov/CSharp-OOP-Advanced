namespace P03_DependencyInversion.IO
{
    using System;
    using P03_DependencyInversion.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}
