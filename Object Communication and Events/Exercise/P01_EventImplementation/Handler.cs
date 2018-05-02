namespace P01_EventImplementation
{
    using P01_EventImplementation.Contracts;
    using System;

    public class Handler : INameChangeHandler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Dispatcher's name changed to {args.Name}.");
        }
    }
}
