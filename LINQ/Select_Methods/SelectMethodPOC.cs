namespace CSharp_Practice.LINQ.Select_Methods
{
    public class SelectMethodPOC
    {
        public static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
            {
              new User() { Name = "Mike", Mail = "mike@gmail.com", Age = 42 },
              new User() { Name = "Bree", Mail = "bree@gmail.com", Age = 34 },
              new User() { Name = "Susan", Mail = "susan@gmail.com", Age = 8 },
              new User() { Name = "Carl", Mail = "carl@gmail.com", Age = 15 },
            };

            var simpleUsers = listOfUsers.Select(user => new
            {
                Name = user.Name,
                Age = user.Age
            });
            foreach (var user in simpleUsers)
            {
                Console.WriteLine(user.Name);
            }
        }

    }
}