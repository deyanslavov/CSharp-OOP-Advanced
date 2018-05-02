public class CreateCommand : Command
{
    public CreateCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory) : base(data, repository, weaponFactory, gemFactory) { }

    public override void Execute()
    {
        string weaponClass = this.Data[1].Split()[1];
        string weaponRarityName = this.Data[1].Split()[0];
        string weaponName = this.Data[2];
        
        IWeapon weapon = this.WeaponFactory.CreateWeapon(weaponClass, weaponRarityName, weaponName);

        if (weapon != null)
        {
            this.Repository.AddWeapon(weapon);
        }
    }
}
