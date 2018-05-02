namespace P03_DependencyInversion.Strategies
{
    using P03_DependencyInversion.Contracts;

    public class AdditionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
