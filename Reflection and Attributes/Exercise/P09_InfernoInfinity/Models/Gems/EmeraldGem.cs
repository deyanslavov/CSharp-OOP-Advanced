public class EmeraldGem : Gem
{
    private const int INITIAL_STRENGTH_VALUE = 1;
    private const int INITIAL_AGILITY_VALUE = 4;
    private const int INITIAL_VITALITY_VALUE = 9;

    public EmeraldGem(GemClarity clarity) : base(clarity, INITIAL_STRENGTH_VALUE, INITIAL_AGILITY_VALUE, INITIAL_VITALITY_VALUE) { }
}
