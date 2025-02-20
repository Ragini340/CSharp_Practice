namespace CSharp_Practice.LINQ.Select_Methods
{
    public class UserList_SelectMethod
    {
        public static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
            {
             new User() { Name = "Gabby", Age = 42 },
             new User() { Name = "Mike", Age = 34 },
             new User() { Name = "Bree", Age = 8 },
             new User() { Name = "Susan", Age = 15 },
            };

            List<string> names = listOfUsers.Select(user => user.Name).ToList();
            List<User> users = names.Select(name => new User { Name = name }).ToList();
            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

    }
}