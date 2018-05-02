using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {

            // Arrange
            int axeAttackDmg = 10;
            int axeDurability = 10;
            int dummyHealth = 10;
            int dummyExp = 10;
            var axe = new Axe(axeAttackDmg, axeDurability);
            var dummy = new Dummy(dummyHealth, dummyExp);
            int expectedDurability = 9;

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(expectedDurability, axe.DurabilityPoints);
        }

        [Test]
        public void AxeCantAttackIfBroken()
        {
            // Arrange
            int axeAttackDmg = 10;
            int axeDurability = 0;
            int dummyHealth = 10;
            int dummyExp = 10;
            var axe = new Axe(axeAttackDmg, axeDurability);
            var dummy = new Dummy(dummyHealth, dummyExp);

            // Act
            //axe.Attack(dummy);

            // Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
