namespace P01_EventImplementation
{
    using P01_EventImplementation.Contracts;
    using System;

    class StartUp
    {
        static void Main()
        {
            INameChangeable dispatcher = new Dispatcher();
            INameChangeHandler handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                dispatcher.Name = line;
            }
        }
    }
}
