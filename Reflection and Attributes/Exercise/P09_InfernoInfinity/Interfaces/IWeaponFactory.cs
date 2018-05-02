public interface IWeaponFactory
{
    IWeapon CreateWeapon(string weaponClass, string rarity, string weaponName);
}
