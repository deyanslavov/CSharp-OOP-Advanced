namespace P01_EventImplementation
{
    using P01_EventImplementation.Contracts;
    
    public class Dispatcher : INameChangeable, INameable
    {
        public event NameChangeEventHandler NameChange;

        private string name;
        
        public string Name
        {
            get => this.name;
            set
            {
                this.OnNameChange(new NameChangeEventArgs(value));
                this.name = value;
            }
        }
        public void OnNameChange(NameChangeEventArgs args)
        {
            if (this.NameChange != null)
            {
                this.NameChange.Invoke(this, args);
            }
        }
    }
}
