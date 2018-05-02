namespace P02_ExtendedDatabaseTests
{
    using NUnit.Framework;
    using P02_ExtendedDatabase;
    using System;
    using System.Collections.Generic;

    public class ExtendedDatabaseTests
    {
        private Database database;

        [SetUp]
        public void InitializeDb()
        {
            this.database = new Database();
        }
        [Test]
        public void CannotAddNullCollectionInDb()
        {
            // Arrange
            var db = new Database(null);

            // Assert
            Assert.AreEqual(0, db.Count);
        }

        [Test]
        public void CannotAddPeopleWithTheSameNameInDb()
        {
            // Act
            this.database.Add(new Person(1, "person1"));

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(11, "person1")));
        }

        [Test]
        public void CannotAddPeopleWithTheSameIdInDb()
        {
            // Act
            this.database.Add(new Person(1, "person1"));

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(1, "person11")));
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void AddPersonIncreasesDbPeopleCount(int peopleCount)
        {
            // Arrange
            for (int i = 0; i < peopleCount; i++)
            {
                this.database.Add(new Person((long)i, "person" + i));
            }

            // Act

            // Assert
            Assert.AreEqual(peopleCount, this.database.Count);
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void CannotRemoveUnexistingPerson(int peopleCount)
        {
            // Arrange
            var people = new List<Person>();
            for (int i = 0; i < peopleCount; i++)
            {
                people.Add(new Person((long)i, "person" + i));
            }
            var db = new Database(people);

            var personToBeRemoved = new Person(100, "notFound");

            // Act
            db.Remove(personToBeRemoved);

            // Assert
            Assert.AreEqual(peopleCount, db.Count);
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void RemoveDecreasesDbPeopleCount(int peopleCount)
        {
            var people = new List<Person>();
            for (int i = 0; i < peopleCount; i++)
            {
                people.Add(new Person((long)i, "person" + i));
            }
            var db = new Database(people);

            var personToBeRemoved = new Person(0, "person0");

            var expectedDbPeopleCount = peopleCount - 1;

            // Act
            db.Remove(personToBeRemoved);

            // Assert
            Assert.AreEqual(expectedDbPeopleCount, db.Count);
        }

        [Test]
        public void FindThrowsExceptionIfDbDoesntContainsPersonWithGivenUsername()
        {
            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Find("notFound"));
        }

        [Test]
        public void FindThrowsExceptionIfUsernameParameterIsNull()
        {
            // Assert
            Assert.Throws<ArgumentNullException>(() => this.database.Find(null));
        }

        [Test]
        public void FindByUsernameReturnsCorrectPerson()
        {
            // Arrange
            var personToFind = new Person(1, "findMe");
            this.database.Add(personToFind);

            // Assert
            Assert.AreEqual(personToFind, this.database.Find("findMe"));
        }

        [Test]
        public void FindThrowsExceptionIfDbDoesntContainsPersonWithGivenId()
        {
            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Find(1));
        }

        [Test]
        public void FindThrowsExceptionIfIdIsNegative()
        {
            // Arrange
            long id = -2;
            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Find(id));
        }

        [Test]
        public void FindByIdReturnsCorrectPerson()
        {
            // Arrange
            var personToFind = new Person(1, "findMe");
            this.database.Add(personToFind);

            // Assert
            Assert.AreEqual(personToFind, this.database.Find(1));
        }
    }
}