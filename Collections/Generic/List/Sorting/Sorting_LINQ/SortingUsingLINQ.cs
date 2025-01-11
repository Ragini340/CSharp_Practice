﻿using CSharp_Practice.Collections.Generic.List.Sorting.Sorting_IComparer;

namespace CSharp_Practice.Collections.Generic.List.Sorting.Sorting_LINQ
{
    public class SortingUsingLINQ
    {
        public static void Main(string[] args)
        {
           List<Employee> employees = new List<Employee>()
           {
           new Employee()
           {
            EmployeeId = 1,
            Name = "Bree",
            Gender = "F",
            Salary = 500000
           },
           new Employee()
           {
            EmployeeId = 2,
            Name = "Mike",
            Gender = "M",
            Salary = 100000
           },
           new Employee()
           {
            EmployeeId = 3,
            Name = "Aasutosh",
            Gender = "M",
            Salary = 5000000
           }
         };

            Console.WriteLine("Employee's list:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
    
            employees =  employees.OrderBy(e => e.Name).ToList();
            Console.WriteLine("\nSorting on the basis of employee's Name:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            employees = employees.OrderByDescending(e => e.Name).ToList();
            Console.WriteLine("\nSorting by employee's Name in decreasing order:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}