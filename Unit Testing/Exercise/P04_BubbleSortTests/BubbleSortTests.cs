namespace P04_BubbleSortTests
{
    using System.Linq;
    using NUnit.Framework;
    using P04_BubbleSort;

    public class BubbleSortTests
    {
        [Test]
        public void BubbleSortSortsCorrectly()
        {
            int[] numbers = new int[] { -2, 0, -1, 0, 0, 5, 1000, 1523, -12414 };
            int[] orderedNumbers = numbers.OrderBy(n => n).ToArray();
            numbers = Bubble.Sort(numbers);


            Assert.AreEqual(orderedNumbers[0], numbers[0]);
        }

        [Test]
        public void BubbleSortWorksCorrectlyWithMinAndMaxValue()
        {
            int[] numbers = new int[] { int.MaxValue, int.MinValue, 0, -2, 5 };
            int[] orderedNumbers = numbers.OrderBy(n => n).ToArray();
            numbers = Bubble.Sort(numbers);


            Assert.AreEqual(orderedNumbers[2], numbers[2]);
        }
    }
}