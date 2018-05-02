namespace P04_BarrackWarsTheCommandsStrikeBack
{
    class StartUp
    {
        static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
