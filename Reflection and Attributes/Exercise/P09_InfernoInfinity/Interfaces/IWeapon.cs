public interface IWeapon
{
    string Name { get; }

    WeaponRarity Rarity { get; }

    int MinDamage { get; }

    int MaxDamage { get; }

    IGem[] Sockets { get; }

    void RemoveGem(int index);

    void AddGem(int index, IGem gem);
}
