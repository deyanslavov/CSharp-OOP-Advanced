namespace P03_DependencyInversion.Models
{
    using P03_DependencyInversion.Contracts;
    using P03_DependencyInversion.Strategies;

    public class Calculator : ICalculator
    {
        private IStrategy calculationStrategy;

        public Calculator()
            : this(new AdditionStrategy())
        {
        }

        public Calculator(IStrategy strategy)
        {
            this.calculationStrategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy) => this.calculationStrategy = strategy;

        public int PerformCalculation(int firstOperand, int secondOperand) => this.calculationStrategy.Calculate(firstOperand, secondOperand);
    }
}
