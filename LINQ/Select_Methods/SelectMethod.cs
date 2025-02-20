namespace CSharp_Practice.LINQ.Select_Methods
{
    public class SelectMethod
    {
        public static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
            {
            new User() { Name = "Mike", Age = 42 },
            new User() { Name = "Bree", Age = 34 },
            new User() { Name = "Susan", Age = 8 },
            new User() { Name = "Carl", Age = 15 },
            };

            List<string> names = listOfUsers.Select(user => user.Name).ToList();
            Console.WriteLine("Names from User's list: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}