using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class DummyTests
    {
        [Test]
        public void DummyLosesHealthAfterBeingAttacked()
        {
            // Arrange
            int axeAttackDmg = 2;
            int axeDurability = 5;
            var axe = new Axe(axeAttackDmg, axeDurability);
            int dummyHealth = 10;
            int dummyExp = 2;
            var dummy = new Dummy(dummyHealth, dummyExp);

            var expectedDummyHealth = 8;

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(expectedDummyHealth, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptionWhenAttacked()
        {
            // Arrange
            int axeAttackDmg = 2;
            int axeDurability = 5;
            var axe = new Axe(axeAttackDmg, axeDurability);
            int dummyHealth = 0;
            int dummyExp = 2;
            var dummy = new Dummy(dummyHealth, dummyExp);

            // Act
            //axe.Attack(dummy);

            // Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            // Arrange
            var hero = new Hero("Superhero", new Axe(10, 10));
            int dummyHealth = 2;
            int dummyExp = 2;
            var dummy = new Dummy(dummyHealth, dummyExp);
            int expectedExp = 2;

            // Act
            hero.Attack(dummy);

            // Assert
            Assert.AreEqual(expectedExp, hero.Experience);
        }

        [Test]
        public void AliveDummyDoesntGiveExperience()
        {
            // Arrange
            var hero = new Hero("Superhero", new Axe(10, 10));
            int dummyHealth = 20;
            int dummyExp = 2;
            var dummy = new Dummy(dummyHealth, dummyExp);
            int expectedExp = 0;

            // Act
            hero.Attack(dummy);

            // Assert
            Assert.AreEqual(expectedExp, hero.Experience);
        }
    }
}
