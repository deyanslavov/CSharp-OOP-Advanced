namespace P02_KingsGambit.Contracts
{
    public interface ISubordinate : INameable, IKillable
    {
        string Action { get; }

        void ReactToAttack();
    }
}
