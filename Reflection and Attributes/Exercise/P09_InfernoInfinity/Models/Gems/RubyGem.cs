public class RubyGem : Gem
{
    private const int INITIAL_STRENGTH_VALUE = 7;
    private const int INITIAL_AGILITY_VALUE = 2;
    private const int INITIAL_VITALITY_VALUE = 5;

    public RubyGem(GemClarity clarity) : base(clarity, INITIAL_STRENGTH_VALUE, INITIAL_AGILITY_VALUE, INITIAL_VITALITY_VALUE) { }
}
