namespace CSharp_Practice.Collections.Generic.List.Sorting.Complex_Sorting
{
    public class SortingOnMultipleCriteria
    {
        public static void Main(string[] args)
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>()
            {
            new EmployeeDetails
            {
            EmployeeId = 1,
            Name = "Bree",
            Salary = 200000,
            Department = "R & D",
            DOJ = new DateTime(2015, 12, 26)
            },
            new EmployeeDetails
            {
            EmployeeId = 2,
            Name = "Bree",
            Salary = 100000,
            Department = "R & D",
            DOJ = new DateTime(2015, 12, 24)
            },
            new EmployeeDetails
            {
            EmployeeId = 3,
            Name = "Carl",
            Salary = 500000,
            Department = "Development",
            DOJ = new DateTime(2015, 12, 26)
            },
            new EmployeeDetails
            {
            EmployeeId = 4,
            Name = "Juli",
            Salary = 2300000,
            Department = "Support",
            DOJ = new DateTime(2015, 12, 27)
            },
            new EmployeeDetails
            {
            EmployeeId = 5,
            Name = "Susan",
            Salary = 100000,
            Department = "R & D",
            DOJ = new DateTime(2015, 12, 25)
            }
           };

            //Filter all the employee whose department is R & D then sort the employees in descending order and then DOJ in ascending order:-
            List<EmployeeDetails> findEmployeeDetails = employeeDetails.FindAll(e => e.Department == "R & D").OrderByDescending(e => e.Salary).ThenBy(e => e.DOJ).ToList();
            Console.WriteLine("\nFiltered employee details on the basis of R & D department and sorted on the basis of salary in descending and on the basis of DOJ in ascending:-");
            foreach (var item in findEmployeeDetails)
            {
                Console.WriteLine(item);
            };

            //Sort employee based on salary in decreasing order then by Name in alphabetical order and then by DOJ in ascending order using methods:-
            Console.WriteLine("\nSorted employee based on salary in decreasing order then by Name in alphabetical order and then by DOJ in ascending order using method:-");
            List<EmployeeDetails> employeesDetails = employeeDetails.OrderByDescending(e => e.Salary).ThenBy(e => e.Name).ThenBy(e => e.DOJ).ToList();
            foreach (var item in employeesDetails)
            {
                Console.WriteLine(item);
            };

            //Sort employee based on salary in decreasing order then by Name in alphabetical order and then by DOJ in ascending order using Query syntax:-
            Console.WriteLine("\nSorted employee based on salary in decreasing order then by Name in alphabetical order and then by DOJ in ascending order using Query syntax:-");
            var employees = (from emp in employeeDetails orderby emp.Salary descending, emp.Name ascending, emp.DOJ ascending select emp).ToList();
            foreach (var employeeList in employees)
            {
                Console.WriteLine(employeeList);
            }
        }
    }

}