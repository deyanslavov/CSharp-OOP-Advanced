﻿namespace P02_KingsGambit.Contracts
{
    public delegate void GetAttackedEventHandler();

    public interface IAttackable
    {
        event GetAttackedEventHandler GetAttackedEvent;

        void ReceiveAttack();
    }
}
