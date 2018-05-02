public class Sword : Weapon
{
    private const int INITIAL_MIN_DAMAGE = 4;
    private const int INITIAL_MAX_DAMAGE = 6;
    private const int NUMBER_OF_SOCKETS = 3;

    public Sword(WeaponRarity rarity, string name) : base(rarity, name, NUMBER_OF_SOCKETS, INITIAL_MIN_DAMAGE, INITIAL_MAX_DAMAGE) { }
}
