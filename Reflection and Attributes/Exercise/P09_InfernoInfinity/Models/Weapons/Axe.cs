public class Axe : Weapon
{
    private const int INITIAL_MIN_DAMAGE = 5;
    private const int INITIAL_MAX_DAMAGE = 10;
    private const int NUMBER_OF_SOCKETS = 4;

    public Axe(WeaponRarity rarity, string name) : base(rarity, name, NUMBER_OF_SOCKETS, INITIAL_MIN_DAMAGE, INITIAL_MAX_DAMAGE) { }
}
