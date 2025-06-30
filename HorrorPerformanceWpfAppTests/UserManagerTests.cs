using System.Diagnostics;

namespace HorrorPerformanceWpfApp.Tests;

[TestClass()]
public class UserManagerTests
{
    [TestMethod()]
    public void GetUsersTest()
    {
        var userManager = new UserManager(@".\Resources\DummyData.csv");
        Assert.AreEqual(userManager.Users.Count(), 3000);
    }

    [TestMethod()]
    public void GetAverageAgeTest()
    {
        var sw = Stopwatch.StartNew();
        var userManager = new UserManager(@".\Resources\DummyData.csv");
        var avgAge = userManager.GetAverageAge();
        sw.Stop();
        Assert.AreEqual(avgAge, 46);
        Assert.IsTrue(sw.ElapsedMilliseconds < 1000, "GetAverageAge took too long to execute.");
    }
}
