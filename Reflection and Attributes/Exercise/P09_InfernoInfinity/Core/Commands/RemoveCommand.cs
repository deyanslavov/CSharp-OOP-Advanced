public class RemoveCommand : Command
{
    public RemoveCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory) : base(data, repository, weaponFactory, gemFactory) { }

    public override void Execute()
    {
        var weaponName = this.Data[1];
        int index = int.Parse(this.Data[2]);

        IWeapon weapon = this.Repository.GetWeapon(weaponName);

        if (weapon != null)
        {
            weapon.RemoveGem(index);
        }
    }
}
