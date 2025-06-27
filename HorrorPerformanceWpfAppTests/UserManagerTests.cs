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
    [Timeout(1000)]
    public void GetAverageAgeTest()
    {
        var userManager = new UserManager(@".\Resources\DummyData.csv");
        var avgAge = userManager.GetAverageAge();
        Assert.AreEqual(avgAge, 46);
    }
}