using BLL;
using DAL;
using NUnit.Framework;

namespace BLL.Tests;

[TestFixture]
public class RoboBudManagerTests
{
    [Test]
    public void GetInstance_CalledTwice_ReturnsSameManagerInstance()
    {
        RoboBudManager manager1 = RoboBudManager.GetInstance();
        RoboBudManager manager2 = RoboBudManager.GetInstance();
        Assert.That(manager2, Is.SameAs(manager1));
    }

    [Test]
    public void GetInstance_CalledTwice_ReturnsSameRobotInstance()
    {
        RoboBudManager manager1 = RoboBudManager.GetInstance();
        RoboBudManager manager2 = RoboBudManager.GetInstance();
        RoboBud robot1 = manager1.Robot;
        RoboBud robot2 = manager2.Robot;
        Assert.That(robot2, Is.SameAs(robot1));
    }
}

