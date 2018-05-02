namespace P05_KingsGambitExtended.Contracts
{
    public delegate void GetAttackedEventHandler();

    public interface IAttackable
    {
        event GetAttackedEventHandler GetAttackedEvent;

        void ReceiveAttack();
    }
}
