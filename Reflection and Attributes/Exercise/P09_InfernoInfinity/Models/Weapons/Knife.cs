public class Knife : Weapon
{
    private const int INITIAL_MIN_DAMAGE = 3;
    private const int INITIAL_MAX_DAMAGE = 4;
    private const int NUMBER_OF_SOCKETS = 2;

    public Knife(WeaponRarity rarity, string name) : base(rarity, name, NUMBER_OF_SOCKETS, INITIAL_MIN_DAMAGE, INITIAL_MAX_DAMAGE) { }
}
