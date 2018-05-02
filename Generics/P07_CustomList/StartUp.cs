namespace P07_CustomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var commandInterpreter = new CommandInterpreter();
            commandInterpreter.ReadCommands();
        }
    }
}
