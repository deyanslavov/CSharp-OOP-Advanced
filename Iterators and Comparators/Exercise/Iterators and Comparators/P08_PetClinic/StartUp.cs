namespace P08_PetClinic
{
    class StartUp
    {
        static void Main()
        {
            var manager = new ClinicManager();
            manager.ReadCommands();
        }
    }
}
