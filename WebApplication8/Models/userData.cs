namespace WebApplication8.Models
{
    public class userData
    {
        public static List<user>? userList = new List<user>()
        {
            new user("Kate", "kate@gmail.com", "123", "admin"),
            new user("Paul", "paul@gmail.com", "123", "customer"),
        };

    }
}
