using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace Tests
{
    public class HeroTests
    {
        [Test]
        public void HeroGainsXPWhenTargetDies()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            var hero = new Hero("SuperHero", fakeWeapon.Object);

            // Act
            fakeTarget.Setup(t => t.Health).Returns(0);
            fakeTarget.Setup(t => t.GiveExperience()).Returns(10);
            fakeTarget.Setup(t => t.IsDead()).Returns(true);

            hero.Attack(fakeTarget.Object);
            

            // Assert
            Assert.That(hero.Experience, Is.EqualTo(10));
        }
    }
}
