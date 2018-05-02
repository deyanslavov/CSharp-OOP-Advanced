public class RetireCommand : Command
{
    public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
    {
    }

    public override string Execute()
    {
        var unitType = this.Data[1];
        string output = "No such units in repository.";

        string searchValue = unitType + " -> 0";
        var statistics = this.Repository.Statistics;

        if (!statistics.Contains(searchValue) && statistics.Contains(unitType))
        {
            output = unitType + " retired!";
            this.Repository.RemoveUnit(unitType);
        }
        return output;
    }
}
