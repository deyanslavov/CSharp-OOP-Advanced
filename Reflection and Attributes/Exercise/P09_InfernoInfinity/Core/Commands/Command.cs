public abstract class Command : ICommand
{
    private string[] data;
    private IRepository repository;
    private IWeaponFactory weaponFactory;
    private IGemFactory gemFactory;

    protected Command(string[] data, IRepository repository)
    {
        this.data = data;
        this.repository = repository;
    }

    protected Command(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
        : this(data, repository, gemFactory)
    {
        this.weaponFactory = weaponFactory;
    }

    protected Command(string[] data, IRepository repository, IGemFactory gemFactory)
        : this(data, repository)
    {
        this.gemFactory = gemFactory;
    }

    protected Command(string[] data, IRepository repository, IWeaponFactory weaponFactory)
        : this(data, repository)
    {
        this.weaponFactory = weaponFactory;
    }

    protected string[] Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    protected IRepository Repository
    {
        get { return this.repository; }
        private set { this.repository = value; }
    }

    protected IWeaponFactory WeaponFactory
    {
        get { return this.weaponFactory; }
        private set { this.weaponFactory = value; }
    }

    protected IGemFactory GemFactory
    {
        get { return this.gemFactory; }
        private set { this.gemFactory = value; }
    }

    public abstract void Execute();
}
