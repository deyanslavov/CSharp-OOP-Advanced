namespace P03_DependencyInversion.Strategies
{
    using P03_DependencyInversion.Contracts;

    public class MultiplicationStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand) => firstOperand * secondOperand;
    }
}
