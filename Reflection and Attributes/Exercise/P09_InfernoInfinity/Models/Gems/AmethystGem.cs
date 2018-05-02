public class AmethystGem : Gem
{
    private const int INITIAL_STRENGTH_VALUE = 2;
    private const int INITIAL_AGILITY_VALUE = 8;
    private const int INITIAL_VITALITY_VALUE = 4;

    public AmethystGem(GemClarity clarity) : base(clarity, INITIAL_STRENGTH_VALUE, INITIAL_AGILITY_VALUE, INITIAL_VITALITY_VALUE) { }
}
