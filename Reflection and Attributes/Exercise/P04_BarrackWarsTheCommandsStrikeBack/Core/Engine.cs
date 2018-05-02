using System;

class Engine : IRunnable
{
    private IRepository repository;
    private IUnitFactory unitFactory;

    public Engine(IRepository repository, IUnitFactory unitFactory)
    {
        this.repository = repository;
        this.unitFactory = unitFactory;
    }

    public void Run()
    {
        string input;
        while ((input = Console.ReadLine()) != "fight")
        {
            try
            {
                string[] data = input.Split();
                string commandName = data[0];

                Console.WriteLine(InterpredCommand(data, commandName));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
    private string InterpredCommand(string[] data, string commandName)
    {
        CommandInterpreter commandInterpreter = new CommandInterpreter(data, this.repository, this.unitFactory);
        return commandInterpreter.IntepredCommand(commandName);
    }
}
