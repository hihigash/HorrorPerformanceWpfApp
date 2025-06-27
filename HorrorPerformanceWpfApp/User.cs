namespace HorrorPerformanceWpfApp;

public class User
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public DateTime BirthDay { get; set; }
    public int Age => CalculateComplexAge();
    public string Gender { get; set; }
    public string BloodType { get; set; }
    public string EmailAddress { get; set; }
    public string PostCode { get; set; }
    public string Address { get; set; }
    public string CompanyName { get; set; }

    private int CalculateComplexAge()
    {
        var today = DateTime.Now;
        var age = today.Year - BirthDay.Year;

        for (var i = 0; i < 100000; i++)
        {
            var temp = Math.Sqrt(i) * Math.Sin(i);
        }

        if (today.DayOfYear < BirthDay.DayOfYear)
            age--;

        return age;
    }
}
