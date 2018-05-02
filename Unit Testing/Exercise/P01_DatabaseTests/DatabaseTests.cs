namespace P01_DatabaseTests
{
    using NUnit.Framework;
    using P01_Database;
    using System;

    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void InitializeDatabase()
        {
            this.database = new Database();
        }

        [Test]
        public void ConstructorShouldTakeNoMoreThan16Numbers()
        {
            // Arrange
            var testCollection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database = new Database(testCollection));
        }

        [Test]
        public void AddShouldThrowExceptionIfDbArrayIsFull()
        {
            // Arrange
            var db = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(1));
        }

        [TestCase(5)]
        [TestCase(9)]
        [TestCase(15)]
        public void AddShouldAddAnElementAtTheNextFreeCell(int numbersCount)
        {
            // Arrange
            for (int i = 0; i < numbersCount - 1; i++)
            {
                this.database.Add(i);
            }

            // Act
            this.database.Add(100);

            // Assert
            Assert.AreEqual(numbersCount, this.database.Count);
        }

        [TestCase(5)]
        [TestCase(9)]
        [TestCase(15)]
        public void RemoveShouldRemoveAnElementAtTheLastCell(int numbersCount)
        {
            // Arrange
            for (int i = 0; i < numbersCount - 1; i++)
            {
                this.database.Add(i);
            }

            // Act
            this.database.Remove();

            // Assert
            Assert.AreEqual(numbersCount - 2, this.database.Count);
        }

        [Test]
        public void RemoveShouldThrowExceptionIfDbIsEmpty()
        {
            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void DatabaseInitializationWithCollectionContainingMoreThanItsCapacityShouldThrowException()
        {
            // Arrange
            var testCollection = new int[16 + 1];

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database = new Database(testCollection));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 12312, 312423, 412, 43, 1, 231212312, 1354, 31213412, 123 })]
        public void FetchMethodShouldReturnTheElementsAsArray(int[] numbers)
        {
            // Arrange
            for (int i = 0; i < numbers.Length; i++)
            {
                this.database.Add(numbers[i]);
            }

            var dbFetch = this.database.Fetch();


            Assert.AreEqual(numbers[5], dbFetch[5]);

        }
    }
}