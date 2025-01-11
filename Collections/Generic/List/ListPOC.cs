using System.Collections.ObjectModel;

namespace CSharp_Practice.Collections.Generic.List
{
    public class ListPOC
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("Gaby");
            list1.Add("Bree");

            List<string> list2 = new List<string>();
            list2.Add("100");
            list2.Add("101");

            //AddRange
            list1.AddRange(list2);
            Console.WriteLine("list1 data:-");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            //Creating a list collection using collection initializer 
            List<string> list3 = new List<string>
            {
                "Zach",
                "Juli",
            };

            //Accessing list elements using for loop
            Console.WriteLine("\nAccessing list3 using for loop:-");
            for (int i = 0; i < list3.Count; i++)
            {
                var element = list3[i];
                Console.WriteLine(element);
            }

            //Accessing list elements by using the index 
            Console.WriteLine("\nAccessing list3 elements by index position");
            Console.WriteLine($"First element:- {list3[0]}");
            Console.WriteLine($"Second element:- {list3[1]}");

            //Insert
            list3.Insert(1, "Mike"); //Inserting "Mike" at index 1, so "Juli" will be shifted to index 2
            Console.WriteLine("\nAccessing list3 after inserting Mike at index 1");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            //InsertRange
            list3.InsertRange(0, list1);
            Console.WriteLine("\nAccessing list3 after InsertRange at index 0:-");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCount of list3 is: " + list3.Count); //Count is 7
            list3.Insert(7, "Ragini");
            Console.WriteLine("\nNow count of list3 is: " + list3.Count);
            Console.WriteLine("\nAccessing list3 after InsertRange at index 7:-");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
            list3.Insert(8, "Rag");
            Console.WriteLine("\nCount of list3 is: " + list3.Count);
            Console.WriteLine("\nAccessing list3 after InsertRange at index 8:-");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            //Contains
            Console.WriteLine("Is Mike exists in list 3? " +list3.Contains("Mike"));

            //Remove
            list3.Remove("Mike");
            Console.WriteLine("\nAccessing list3 after removing item Mike from the list3:-");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            List<int> list4 = new List<int>();
            for(int i = 1; i<= 10; i++)
            {
                list4.Add(i);
            }
            Console.WriteLine("\nElements in list4 are:-");
            foreach(int item in list4)
            {
                Console.WriteLine(item);
            }

            //RemoveAll(Predicate < T > match)
            list4.RemoveAll(num => num %2 == 0);
            Console.WriteLine("\nAfter using RemoveAll method elements in list4 are:-");
            foreach (int item in list4)
            {
                Console.WriteLine(item);
            }

            //RemoveAt
            list4.RemoveAt(list4.Count - 1);
            Console.WriteLine("\nAfter using RemoveAt method elements in list4 are:-");
            foreach (int item in list4)
            {
                Console.WriteLine(item);
            }

            //RemoveRange
            list4.RemoveRange(1, 2); //It will remove list elements at index 1 and index 2
            Console.WriteLine("\nAfter using RemoveRange method elements in list4 are:-");
            foreach (int item in list4)
            {
                Console.WriteLine(item);
            }

            //Clear
            list4.Clear();
            Console.WriteLine("\nCount in list4 is: " + list4.Count);

            //Copying an array to a list 
            string[] arr = new string[] { "India", "USA", "Pakistan" };
            List<string> copiedListFromArray = new List<string>(arr);
            Console.WriteLine("\nElements of copiedListFromArray:-");
            foreach (var item in copiedListFromArray)
            {
                Console.WriteLine(item);
            }

            //List collection with complex type
            Employee employee1 = new Employee()
            {
                EmployeeId = 1,
                Name = "Ragini",
                Gender = "F",
                Salary = 100000
            };
            Employee employee2 = new Employee()
            {
                EmployeeId = 2,
                Name = "Bree",
                Gender = "F",
                Salary = 80000
            };
            Employee employee3 = new Employee()
            {
                EmployeeId = 3,
                Name = "Gaby",
                Gender = "F",
                Salary = 60000
            };

            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            Console.WriteLine("\nElements of employeesList:-");
            foreach (var item in employeesList)
            {
                Console.WriteLine(item);
            }

            //Retrieving items from the employeesList by using index
            Employee employeeAtIndexZero = employeesList[0];
            Console.WriteLine("\nEmployee details at index 0 is:-" + "\n" + employeesList[0]);

            //Retrieving all employees of employeesList using for loop
            Console.WriteLine("\nElements of employeesList using for loop:-");
            for (int i = 0; i < employeesList.Count; i++)
            {
                Console.WriteLine(employeesList[i]);
            }

            Employee employee4 = new Employee()
            {
                EmployeeId = 4,
                Name = "John",
                Gender = "M",
                Salary = 100000
            };
            Employee employee5 = new Employee()
            {
                EmployeeId = 5,
                Name = "Zach",
                Gender = "M",
                Salary = 5000
            };
            //Insert
            employeesList.Insert(1, employee4);
            Console.WriteLine("\nElements in employeesList after inserting employee4 details at index 1:-");
            foreach (var item in employeesList)
            {
                Console.WriteLine(item);
            }

            //Find
            Employee filteredEmployee = employeesList.Find(e => e.Salary == 60000 && e.Gender == "F");
            Console.WriteLine("\nFiltered employee on the basis of salary and gender:- " + filteredEmployee);

            //FindLast
            Employee lastMatchedEmployee = employeesList.FindLast(e => e.Gender == "F" && e.Salary == 100000);
            Console.WriteLine("\nFiltered last matched employee on given condition:- " + lastMatchedEmployee);

            //FindAll
            List<Employee> findAllMatchedEmployee = employeesList.FindAll(e => e.Salary == 60000 || e.Gender == "F");
            Console.WriteLine("\nFiltered employee details on the basis of salary or gender:-");
            foreach (var item in findAllMatchedEmployee)
            {
                Console.WriteLine(item);
            }

            //FindIndex
            //int findIndex = employeesList.FindIndex(null); //Unhandled exception. System.ArgumentNullException: Value cannot be null. (Parameter 'match')
            int findIndex = employeesList.FindIndex(e => e.Salary == 100000 && e.Gender == "F");
            Console.WriteLine("\nIndex is: " + findIndex);

            //FindLastIndex
            int lastIndex = employeesList.FindLastIndex(e => e.Salary == 100000 && e.Gender == "F");
            Console.WriteLine("\nLast index is:" + lastIndex);

            //Exists
            bool isEmployeeDetailExists = employeesList.Exists(e => e.Salary == 1000 && e.Gender == "F");
            Console.WriteLine("\nIs employee exists with given condition? " + isEmployeeDetailExists);

            //Contains
            bool isEmployeeContainsPassedEmployeeObj = employeesList.Contains(employee4);
            Console.WriteLine("\nIs employee contains passed employee object? " + isEmployeeContainsPassedEmployeeObj);

            //TrueForAll
            bool isTrueEmployeeCheckedCondition = employeesList.TrueForAll(e => e.Gender == "M");
            Console.WriteLine("\nEvery element in the list matches the conditions defined by the specified predicate? " + isTrueEmployeeCheckedCondition);

            //Readonly
            Console.WriteLine("Count in employee list: " + employeesList.Count());
            ReadOnlyCollection<Employee> emp = employeesList.AsReadOnly();
            Console.WriteLine("Now Count in employee list: " + employeesList.Count());

            //emp.Add(employee4);  //ReadOnlyCollection<Employee> does not contain a definition for 'Add' and no accessible extention
                                   //method 'Add' accepting a first argument of type ReadOnlyCollection<Employee> could be found
           
            //TrimExcess to set the capacity to the actual number of elements in the List
            Console.WriteLine("\nCapacity is : " + employeesList.Capacity);
            employeesList.TrimExcess();
            Console.WriteLine("\nActual number of elements in the list are:- " + employeesList.Capacity);

            //Sort
            List<int> integerList = new List<int>
            {
               2,4,6,1,22,4,5 
            };
            integerList.Sort();
            Console.WriteLine("\nSorted list in ascending order:-");
            foreach (int list in integerList)
            {
                Console.Write(list + " ");
            }
            Console.WriteLine();

            //Reverse(int index, int count)
            integerList.Reverse(1, 5);
            Console.WriteLine("\nSorting from index 1 to count 5:-");
            foreach(int list in integerList)
            {
                Console.Write(list + " ");
            }
            //Reverse
            integerList.Reverse();
            Console.WriteLine("\nSorted list in decreasing order:-");
            foreach (int list in integerList)
            {
                Console.Write(list + " ");
            }
            Console.WriteLine();

            //employeesList.Sort(); //Unhandled exception. System.InvalidOperationException: Failed to compare two elements in the array.
        }
    }

}