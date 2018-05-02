namespace P03_ListIteratorTests
{
    using NUnit.Framework;
    using P03_ListIterator;
    using System;
    using System.Collections.Generic;

    public class ListIteratorTests
    {
        [Test]
        public void ConstructorShouldThrowExceptionIfParameterIsNull()
        {
            // Arrange
            ListIterator list = null;

            // Assert
            Assert.Throws<ArgumentNullException>(() => list = new ListIterator(null));
        }

        [Test]
        public void MoveNextShouldMoveInternalIndex()
        {
            // Arrange
            var strings = new List<string>() { "string1", "string2", "string3" };
            var list = new ListIterator(strings);
            var expectedIndex = 1;

            // Act
            list.Move();

            // Assert
            Assert.AreEqual(expectedIndex, list.CurrentIndex);
        }

        [Test]
        public void MoveNextShouldReturnFalseIfThereIsNoNextIndex()
        {
            // Arrange
            var strings = new List<string>() { "string1", "string2", "string3" };
            var list = new ListIterator(strings);
            var expectedResult = false;

            // Act
            list.Move();
            list.Move();

            // Assert
            Assert.AreEqual(expectedResult, list.Move());
        }

        [Test]
        public void MoveNextShouldReturnTrueIfThereIsNextIndex()
        {
            // Arrange
            var strings = new List<string>() { "string1", "string2", "string3" };
            var list = new ListIterator(strings);
            var expectedResult = true;

            // Act
            list.Move();

            // Assert
            Assert.AreEqual(expectedResult, list.Move());
        }

        [Test]
        public void HasNextShouldReturnTrueIfThereIsNextIndex()
        {
            // Arrange
            var strings = new List<string>() { "string1", "string2", "string3" };
            var list = new ListIterator(strings);
            var expectedResult = true;

            // Assert
            Assert.AreEqual(expectedResult, list.HasNext());
        }

        [Test]
        public void HasNextShouldReturnFalseIfThereIsNoNextIndex()
        {
            // Arrange
            var strings = new List<string>() { "string1", "string2", "string3" };
            var list = new ListIterator(strings);
            var expectedResult = false;

            // Act
            list.Move();
            list.Move();

            // Assert
            Assert.AreEqual(expectedResult, list.HasNext());
        }

        [Test]
        public void PrintShouldThrowExceptionIfCalledOnEmptyCollection()
        {
            // Arrange
            var strings = new List<string>() { };
            var list = new ListIterator(strings);

            // Assert
            Assert.Throws<InvalidOperationException>(() => list.Print());
        }

        [Test]
        public void PrintShouldPrintTheElementAtTheCurrentIndex()
        {
            // Arrange
            var strings = new List<string>() { "string1", "string2", "string3" };
            var list = new ListIterator(strings);
            var expectedResult = "string3";

            // Act
            list.Move();
            list.Move();

            // Assert
            Assert.AreEqual(expectedResult, list.Print());
        }
    }
}