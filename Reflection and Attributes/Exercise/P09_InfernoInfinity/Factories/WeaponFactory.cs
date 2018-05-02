using System;

public class WeaponFactory : IWeaponFactory
{
    public IWeapon CreateWeapon(string weaponClass, string weaponRarity, string weaponName)
    {
        WeaponRarity rarity;
        var isRarityValid = Enum.TryParse(weaponRarity, out rarity);

        if (!isRarityValid)
        {
            return null;
        }

        var weaponType = Type.GetType(weaponClass);
        
        return (IWeapon)Activator.CreateInstance(weaponType, new object[] { rarity, weaponName });
    }
}
