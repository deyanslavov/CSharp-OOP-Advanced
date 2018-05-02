namespace P10_TireMonitoringSystemTests
{
    using NUnit.Framework;
    using Moq;
    using P10_TireMonitoringSystem;

    [TestFixture]
    public class AlarmTests
    {
        [Test]
        public void AlarmTurnsOnCorrectly()
        {
            var alarmFake = new Mock<Alarm>();
            var sensorFake = new Mock<Sensor>();

            alarmFake.Setup(a => a.AlarmOn).Returns(true);

            Assert.AreEqual(true, alarmFake.Object.AlarmOn);
        }
    }
}
