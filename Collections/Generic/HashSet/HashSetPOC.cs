namespace CSharp_Practice.Collections.Generic.HashSet
{
    public class HashSetPOC
    {
        public static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            //Add
            set.Add("A");
            bool b = set.Add("B");
            Console.WriteLine("Value of b is: " + b); //It will print True 
            set.Add("C");
            set.Add("Apple");
            set.Add("America");
            set.Add("Anita");
            set.Add("Aakash");
            Console.WriteLine("\nHashSet items are: ");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Remove
            bool e = set.Remove("E");
            Console.WriteLine("\nValue of e is: " + e); //It will print False as "E" item is not available in the Hashset

            //RemoveWhere 
            set.RemoveWhere(e => e == "A");
            Console.WriteLine("\nHashSet elements after using RemoveWhere method: ");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int removedCount = set.RemoveWhere(e => e.StartsWith("A"));
            Console.WriteLine("\nNow HashSet elements after using RemoveWhere method: ");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nRemoved elements's count are: " + removedCount);

            //Clear
            set.Clear();
            //Count
            Console.WriteLine("\nAfter using Clear method element's count is: " + set.Count);

            //Adding Elements to HashSet Collection using Collection Initializer
            HashSet<int> set1 = new HashSet<int>
            {
                1, 8, 2, 3, 4, 56, 7
            };
            Console.WriteLine("\nset1 elements are: ");
            foreach (int item in set1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Contains
            bool set1ContainsSpecifiedElement = set1.Contains(56);
            Console.WriteLine("\nIs set1 contain specified element? " + set1ContainsSpecifiedElement);

            //Set Operations on Generic HashSet<T> Collection Class:-
            HashSet<int> set2 = new HashSet<int>
            {
                1, 8, 2, 3, 4, 56, 7, 10, 30, 40
            };
            Console.WriteLine("\nset2 elements are: ");
            foreach (int item in set2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //UnionWith
            set1.UnionWith(set2); //The UnionWith method contains all the elements which are present in both the collection
                                  //while removing the duplicate elements. 
            Console.WriteLine("\nset1 elements after UnionWith set2: ");
            foreach (int item in set1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //IntersectWith
            List<int> set3 = new List<int>
            {
                1, 8, 2, 100
            };
            Console.WriteLine("\nset3 elements are: ");
            foreach (int item in set3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            set2.IntersectWith(set3); //The IntersectWith method contains the common elements which are present in both the collection.
            Console.WriteLine("\nset2 elements after IntersectWith set3: ");
            foreach (int item in set2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //ExceptWith
            set1.ExceptWith(set3); //The ExceptWith method contains the elements from the first collection which are not present in
                                   //the second collection. 
            Console.WriteLine("\nset1 elements after ExceptWith set3: ");
            foreach (int item in set1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //SymmetricExceptWith
            set1.SymmetricExceptWith(set3); //The SymmetricExceptWith method contains elements that are not common in both collections.
            Console.WriteLine("\nset1 elements after SymmetricExceptWith set3: ");
            foreach (int item in set1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //HashSet Collection with Complex Type:-
            HashSet<Employee> employees = new HashSet<Employee>()
            {
                new Employee
                {
                   EmployeeId = 1,
                   Name = "Bree",
                   Gender = "F",
                   Salary = 1000
                },
                new Employee
                {
                   EmployeeId = 1,
                   Name = "Bree",
                   Gender = "F",
                   Salary = 1000
                },
                new Employee
                {
                   EmployeeId = 3,
                   Name = "Susan",
                   Gender = "F",
                   Salary = 5000
                },
                new Employee
                {
                   EmployeeId = 4,
                   Name = "Juli",
                   Gender = "F",
                   Salary = 3000
                },
            };
            Console.WriteLine("\nHashSet employees list:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp + " ");
            }
            Console.WriteLine();
        }
    }

}