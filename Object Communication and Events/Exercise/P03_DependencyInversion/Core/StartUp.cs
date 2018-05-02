namespace P03_DependencyInversion.Core
{
    using P03_DependencyInversion.IO;
    using P03_DependencyInversion.Models;

    class StartUp
    {
        static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var calculator = new Calculator();
            new Engine(calculator, reader, writer).Run();
        }
    }
}
