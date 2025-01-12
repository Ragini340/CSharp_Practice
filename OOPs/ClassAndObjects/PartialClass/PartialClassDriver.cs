namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass
{
    public class PartialClassDriver
    {
        public static void Main(string[] args)
        {
            PartialEmployee partialEmployee = new PartialEmployee
            {
                FirstName = "Ragini",
                LastName = "Ragini",
                Gender = "F",
                Salary = 1200000
            };

            partialEmployee.DisplayFullName();
            partialEmployee.DisplayEmployeeDetails();
            Console.WriteLine(partialEmployee);
        }
    }
}