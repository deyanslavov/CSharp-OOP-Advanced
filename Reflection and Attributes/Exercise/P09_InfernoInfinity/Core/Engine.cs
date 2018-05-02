using System;

public class Engine : IRunnable
{
    private IRepository repository;
    private IWeaponFactory weaponFactory;
    private IGemFactory gemFactory;

    public Engine()
    {
        this.repository = new WeaponRepository();
        this.weaponFactory = new WeaponFactory();
        this.gemFactory = new GemFactory();
    }

    public void Run()
    {
        string line;
        while ((line = Console.ReadLine()) != "END")
        {
            var data = line.Split(';');

            ICommandInterpreter commandInterpreter = new CommandInterpreter(data, this.repository, this.weaponFactory, this.gemFactory);

            commandInterpreter.InterpredCommand();
        }
    }
}
