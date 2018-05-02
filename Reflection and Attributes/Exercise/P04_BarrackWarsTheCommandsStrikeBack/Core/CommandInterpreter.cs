using System;
using System.Linq;
using System.Reflection;

public class CommandInterpreter
{
    private string[] data;
    private IRepository repository;
    private IUnitFactory unitFactory;

    public CommandInterpreter(string[] data, IRepository repository, IUnitFactory unitFactory)
    {
        this.Data = data;
        this.Repository = repository;
        this.UnitFactory = unitFactory;
    }

    public string[] Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    public IRepository Repository
    {
        get { return this.repository; }
        private set { this.repository = value; }
    }

    public IUnitFactory UnitFactory
    {
        get { return this.unitFactory; }
        private set { this.unitFactory = value; }
    }

    public string IntepredCommand(string commandName)
    {
        var commands = Assembly.GetExecutingAssembly().GetTypes().Where(c => c.Name.EndsWith("Command") && c.Name.Length > 8).ToArray();

        var currentCommandType = commands.First(c => c.Name.ToLower().Contains(commandName));

        var commandInstance = (IExecutable)Activator.CreateInstance(currentCommandType, new object[] { this.data, this.repository, this.unitFactory});

        return currentCommandType.GetMethod("Execute").Invoke(commandInstance, new object[] { }).ToString();
    }
}
