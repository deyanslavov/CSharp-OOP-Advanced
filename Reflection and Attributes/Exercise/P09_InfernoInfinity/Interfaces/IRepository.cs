public interface IRepository
{
    void AddWeapon(IWeapon weapon);

    void Print(string weaponName);

    IWeapon GetWeapon(string weaponName);
}
