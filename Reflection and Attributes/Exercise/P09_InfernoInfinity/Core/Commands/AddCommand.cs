public class AddCommand : Command
{
    public AddCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory) : base(data, repository, weaponFactory, gemFactory) { }

    public override void Execute()
    {
        var gemClass = this.Data[3].Split()[1];
        var clarityName = this.Data[3].Split()[0];

        IGem gem = this.GemFactory.CreateGem(gemClass, clarityName);

        var weaponName = this.Data[1];
        int index = int.Parse(this.Data[2]);

        IWeapon weapon = this.Repository.GetWeapon(weaponName);

        if (weapon != null)
        {
            weapon.AddGem(index, gem);
        }
    }
}
