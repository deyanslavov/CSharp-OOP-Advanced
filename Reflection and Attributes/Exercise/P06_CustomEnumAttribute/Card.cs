public class Card
{
    public Card(Suits suit, Ranks rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }

    public Suits Suit { get; private set; }

    public Ranks Rank { get; private set; }

    public int Power => (int)Suit + (int)Rank;

    public override string ToString()
    {
        return $"Card name: {Rank.ToString().ToUpper()} of {Suit.ToString().ToUpper()}; Card power: {Power}";
    }
}
