using System;
using System.Linq;
using System.Reflection;

public class CommandInterpreter : ICommandInterpreter
{
    private string[] data;
    private IRepository repository;
    private IWeaponFactory weaponFactory;
    private IGemFactory gemFactory;

    public CommandInterpreter(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
    {
        this.data = data;
        this.repository = repository;
        this.weaponFactory = weaponFactory;
        this.gemFactory = gemFactory;
    }

    public void InterpredCommand()
    {
        var commandName = this.data[0];

        var commandType = Assembly.GetExecutingAssembly().GetTypes().First(c => c.Name.EndsWith("Command") && c.Name.StartsWith(commandName));

        var commandInstance = (ICommand)Activator.CreateInstance(commandType, new object[] { this.data, this.repository, this.weaponFactory, this.gemFactory });

        commandType.GetMethod("Execute").Invoke(commandInstance, new object[] { });
    }
}
