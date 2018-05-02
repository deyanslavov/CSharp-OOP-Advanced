public class PrintCommand : Command
{
    public PrintCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory) : base(data, repository, weaponFactory, gemFactory) { }
    
    public override void Execute()
    {
        var weaponName = this.Data[1];

        this.Repository.Print(weaponName);
    }
}
