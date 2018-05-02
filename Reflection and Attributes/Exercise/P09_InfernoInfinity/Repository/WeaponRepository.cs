using System;
using System.Collections.Generic;
using System.Linq;

public class WeaponRepository : IRepository
{
    private IList<IWeapon> weapons;

    public WeaponRepository()
    {
        this.weapons = new List<IWeapon>();
    }

    public void AddWeapon(IWeapon weapon)
    {
        this.weapons.Add(weapon);
    }

    public IWeapon GetWeapon(string weaponName)
    {
        return this.weapons.FirstOrDefault(w => w.Name == weaponName);
    }

    public void Print(string weaponName)
    {
        IWeapon weapon = this.weapons.First(w => w.Name == weaponName);
        Console.WriteLine(weapon);
    }
}
