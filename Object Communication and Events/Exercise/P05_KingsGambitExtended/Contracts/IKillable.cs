namespace P05_KingsGambitExtended.Contracts
{
    public interface IKillable : IAlive
    {
        void Die();

        int HitPoints { get; }

        void TakeDamage();
    }
}
