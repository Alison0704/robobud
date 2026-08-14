using BLL;
using Core;
using NUnit.Framework;

namespace BLL.Tests;

[TestFixture]
public class RobotStatusServiceTests
{
    private RobotStatusService _service = null!;

    [SetUp]
    public void SetUp()
    {
        _service = new RobotStatusService();
    }

    [Test]
    [TestCase(RobotStatus.ACCEPT, true)]
    [TestCase(RobotStatus.RELUCTANT, false)]
    [TestCase(RobotStatus.REFUSE, false)]
    public void CanReceiveTask_ReturnsExpectedResult(
        RobotStatus status,
        bool expected)
    {
        bool result = _service.CanReceiveTask(status);

        Assert.That(result, Is.EqualTo(expected));
    }
}