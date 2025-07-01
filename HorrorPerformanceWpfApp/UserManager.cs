using nietras.SeparatedValues;

namespace HorrorPerformanceWpfApp;

public class UserManager
{
    public List<User> Users { get; }

    public UserManager(string fileName)
    {
        Users = GetUsers(fileName);
    }

    private List<User> GetUsers(string fileName)
    {
        var allUsers = new List<User>();
        using var reader = Sep.Reader().FromFile(fileName);

        foreach (var row in reader)
        {
            var user = new User
            {
                Name = row["Name"].ToString(),
                DisplayName = row["DisplayName"].ToString(),
                BirthDay = row["Birthday"].Parse<DateTime>(),
                Gender = row["Gender"].ToString(),
                BloodType = row["BloodType"].ToString(),
                EmailAddress = row["EmailAddress"].ToString(),
                PostCode = row["PostCode"].ToString(),
                Address = row["Address"].ToString(),
                CompanyName = row["CompanyName"].ToString()
            };
            allUsers.Add(user);
        }
        return allUsers;
    }

    public int GetAverageAge()
    {
        if (Users?.Count == 0)
            throw new InvalidOperationException("User data is not loaded or empty.");

        return (int)Users.Average(user => user.Age);
    }
}
