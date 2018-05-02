using System.Linq;

public abstract class Weapon : IWeapon
{
    protected Weapon(WeaponRarity rarity, string name, int numberOfSockets, int minDamage, int maxDamage)
    {
        this.Rarity = rarity;
        this.Name = name;
        this.Sockets = new IGem[numberOfSockets];
        this.MinDamage = minDamage * (int)rarity;
        this.MaxDamage = maxDamage * (int)rarity;
    }

    public string Name { get; private set; }

    public WeaponRarity Rarity { get; private set; }

    public int MinDamage { get; private set; }

    public int MaxDamage { get; private set; }

    public IGem[] Sockets { get; private set; }
    
    public void AddGem(int socketIndex, IGem gem)
    {
        if (socketIndex < 0 || socketIndex >= this.Sockets.Length)
        {
            return;
        }

        this.Sockets[socketIndex] = gem;
    }

    public void RemoveGem(int socketIndex)
    {
        if (socketIndex < 0 || socketIndex >= this.Sockets.Length)
        {
            return;
        }

        this.Sockets[socketIndex] = null;
    }

    private int Strength => this.Sockets.Where(g => g != null).Sum(g => g.Strength);

    private int Agility => this.Sockets.Where(g => g != null).Sum(g => g.Agility);

    private int Vitality => this.Sockets.Where(g => g != null).Sum(g => g.Vitality);

    public override string ToString()
    {
        var minDamage = this.MinDamage + (this.Strength * 2) + this.Agility;
        var maxDamage = this.MaxDamage + (this.Strength * 3) + (this.Agility * 4);

        return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
    }
}
