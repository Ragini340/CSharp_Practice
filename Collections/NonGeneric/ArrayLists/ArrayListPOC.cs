using System.Collections;
using CSharp_Practice.Indexer.Indexer_Real_Life_Example;

namespace CSharp_Practice.Collections.NonGeneric.ArrayLists
{
    //ArrayList: IList, ICloneable
    public class ArrayListPOC
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Capacity is: " + arrayList.Capacity);
            Console.WriteLine("Count is: " + arrayList.Count);

            ArrayList arrayList1 = new ArrayList(5);
            Console.WriteLine("Capacity is: " + arrayList1.Capacity);
            Console.WriteLine("Count is: " + arrayList1.Count);

            arrayList1.Add(100);
            arrayList1.Add("Ragini");
            arrayList1.Add("Ragini");
            arrayList1.Add(" ");
            arrayList1.Add(true);
            arrayList1.Add(4.02);
            arrayList1.Add(null);
            Console.WriteLine("ArrayList1 elements are:-");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Accessing list elements using index
            int firstElement = (int)arrayList1[0];
            string secondElement = (string)arrayList1[1];
            string thirdElement = (string)arrayList1[2];
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}, Third Element: {thirdElement} ");

            //Accessing list elements using var keyword without explicit casting
            var firsItem = arrayList1[0];
            var secondItem = arrayList1[1];
            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");

            var arrayList2 = new ArrayList()
            {
                101,
                "Singh",
                "Singh",
                false,
                10.5
            };
            Console.WriteLine("Capacity of arrayList2 is: " + arrayList2.Capacity); //Default capacity of ArrayList is 4, so in arrayList2
                                                                                    //we have 5 elements, so its capacity will be 8. If in
                                                                                    //arrayList2 we have 9 elements then it's capacity will be
                                                                                    //12.
            Console.WriteLine("ArrayList2 elements are:-");
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Updating elements of arrayList2
            arrayList2[0] = "Bree";
            arrayList2[1] = 1000;
            Console.WriteLine("Updated ArrayList2 elements are:-");
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Iterating using for loop
            Console.WriteLine("Iterating using for loop");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.Write($"{arrayList2[i]} ");
            }
            Console.WriteLine();

            //Insert
            arrayList2.Insert(0, 1); //Inserting 1 at index 0
            arrayList2.Insert(2, "Susan"); //Inserting Susan at index 2
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ArrayList arrayList3 = new ArrayList()
            {
                    "Gaby",
                    "July",
                    "Stereolane"
            };

            //Inserting collection
            arrayList2.InsertRange(2, arrayList3);  //Inserting arrayList3 at index 2
            Console.WriteLine("Array List elements after InsertRange:-");
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Remove, RemoveAt, RemoveRange, Clear
            arrayList2.Remove("Gaby");
            arrayList2.RemoveAt(1);
            arrayList2.RemoveRange(0, 5);
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            arrayList2.Clear();
            Console.WriteLine("Now count of arrayList2 is: " + arrayList2.Count);
            Console.WriteLine("Now capacity of arrayList2 is: " + arrayList2.Capacity);

            //Contains
            Console.WriteLine($"Is arrayList1 Contains 4.02: {arrayList1.Contains(4.02)}");
            if (arrayList1.Contains(100))
                Console.WriteLine("Yes, exists at index " + arrayList1.IndexOf(100));
            else
                Console.WriteLine("No, doesn't exists");

            //Clone
            ArrayList clonedArrayList = (ArrayList)arrayList1.Clone();
            Console.WriteLine("Cloned ArrayList elements are:-");
            foreach (var item in clonedArrayList)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("arrayList1 hashcode: " + arrayList1.GetHashCode());
            Console.WriteLine("clonedArrayList hashcode: " + clonedArrayList.GetHashCode());

            clonedArrayList[0] = "Test";
            Console.WriteLine("Modified Cloned ArrayList:-");
            foreach (var item in clonedArrayList)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("arrayList1 hashcode: " + arrayList1.GetHashCode());
            Console.WriteLine("clonedArrayList hashcode: " + clonedArrayList.GetHashCode());
            Console.WriteLine("Now arrayList1 elements are:-");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //CopyTo(Array array)
            object[] arrayListCopy = new object[arrayList1.Count];
            arrayList1.CopyTo(arrayListCopy);
            Console.WriteLine("Elements after using CopyTo method:-");
            foreach (var item in arrayListCopy)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            //ArrayList.CopyTo(Array, Int32) Method 
            ArrayList myList = new ArrayList();
            myList.Add("D");
            myList.Add("B");
            myList.Add("F");
            string[] arr = new string[3];
            arr[0] = "C#";
            arr[1] = "Programming";
            arr[2] = "Language";
            // myList.CopyTo(arr, 1);  ///Error Unhandled exception. System.ArgumentException: Destination array was not long enough. Check the destination index, length, and the array's lower bounds. (Parameter 'destinationArray')
            // at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
            // at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
            //Because it will start copying in arr from index 1, so in ArrayList number of elements are 3, then it will copy only first two data from ArrayList to array i.e. A and B, so what about C?
            //C can't be copied in arr because A will go on index 1 in array and B will go on index 2 in Array and total array size is 3, so index will be 0, 1, 2, hence we can't copy C because last index of array is 2.

            myList.CopyTo(arr, 0);
            foreach (var item in myList)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("Coped arraylist data to array arr:");
            foreach (var item in arr)
            {
                Console.WriteLine(" " + item);
            }

            //Clone
            Employee employee = new Employee();
            employee.Name = "Mike";
            employee.Salary = 100;
            employee.Gender = "M";
            employee.EmployeeId = 1;

            ArrayList employees = new ArrayList();
            employees.Add(employee);

            Employee employee2 = new Employee();
            employee2.Name = "Carl";
            employee2.Salary = 1000;
            employee2.Gender = "M";
            employee2.EmployeeId = 2;
            employees.Add(employee2);

            ArrayList clonedEmployee = (ArrayList)employees.Clone();
            Employee emp1 = (Employee)clonedEmployee[0];
            emp1.Name = "Eddi";

            //Name has been changed in actual object employee and list where we have added employee and cloned list which has been cloned from original list.
            Console.WriteLine(clonedEmployee[0]);
            Console.WriteLine("Employees element at index zero:" + employees[0]);
            Console.WriteLine(employee);

            //Above one is shallow copy    --- so here, how can we avoid shallow copy? Need to fix the shallow copy 
            CloneableEmployee cloneableEmployee = new CloneableEmployee();
            cloneableEmployee.Name = "Julee";
            cloneableEmployee.Salary = 120;
            cloneableEmployee.EmployeeId = 123;
            cloneableEmployee.Gender = "F";
            ArrayList newEmployees = new ArrayList();
            newEmployees.Add(cloneableEmployee);
            Console.WriteLine("Original details:- ");
            Console.WriteLine(cloneableEmployee);
            Console.WriteLine(cloneableEmployee.GetHashCode());

            ArrayList aL = (ArrayList)newEmployees.Clone();
            CloneableEmployee emp = (CloneableEmployee)aL[0];

            CloneableEmployee clonedEmp = (CloneableEmployee)emp.Clone();
            clonedEmp.Name = "Test";
            aL[0] = clonedEmp;

            Console.WriteLine("Original list data at index 0: " + newEmployees[0]);
            Console.WriteLine("Cloned list data at index 0: " + aL[0]);

            //Sort(): It will sort in ascending order
            myList.Sort();
            Console.WriteLine("Sorted myList elements in ascending order:- ");
            foreach (var item in myList)
            {
                Console.WriteLine(item + " ");
            }

            myList.Reverse(); //It will sort in descending order
            Console.WriteLine("Sorted myList elements in descending order:- ");
            foreach (var item in myList)
            {
                Console.WriteLine(item + " ");
            }

            //Sort(IComparer? comparer):- It will not work with Non-Generic collections
            ArrayList empList = new ArrayList();
            Employee e = new Employee();
            e.Name = "Ragini";
            e.Salary = 10;
            e.Gender = "F";
            e.EmployeeId = 1;

            empList.Add(e);

            Employee e2 = new Employee();
            e2.Name = "Nina";
            e2.Salary = 100;
            e2.Gender = "F";
            e2.EmployeeId = 2;

            empList.Add(e2);

            Console.WriteLine("Count: " + empList.Count);
            foreach (var item in empList)
            {
                Console.WriteLine(item + " ");
            }

            //EmployeeComparer employeeComparer = new EmployeeComparer();
            //empList.Sort(employeeCompare); --It will not work with Non-Generic collections
        }
    }

}