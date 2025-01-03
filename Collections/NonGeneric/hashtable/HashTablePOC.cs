using System.Collections;
using CSharp_Practice.Indexer.Indexer_Real_Life_Example;

namespace CSharp_Practice.Collections.NonGeneric.hashtable
{
    public class HashTablePOC
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable(); //Initial capacity is 0
            Hashtable hashTable1 = new Hashtable(3);
            //Hashtable hashTable2 = new Hashtable(4, 5.0f); // System.ArgumentOutOfRangeException: Load factor needs to be between 0.1 and 1.0. (Parameter 'loadFactor')
            Hashtable hashTable2 = new Hashtable(4, 1.0f);
            Console.WriteLine("Initial capacity is: " + hashtable.Count);

            hashtable.Add("Name", "Susan");
            hashtable.Add("Salary", null);  //Hashtable values can be null but key can't be null.
            hashtable.Add("Location", "USA");
            hashtable.Add("EmailId", "susan@31gmail.com");
            Console.WriteLine("Hashtable elements are:- ");
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }
            Console.WriteLine();

            //Adding elements to a Hashtable using Collection Initializer:-
            Hashtable collctionInitializer = new Hashtable()
            {
                { "India", "Bangalore, Pune, Mumbai" },
                { "USA", "Chicgo, WDC" },
                { "UK", null },
            };

            foreach (string key in collctionInitializer.Keys)
            {
                Console.WriteLine(key + ": " + collctionInitializer[key]);
            }
            Console.WriteLine();
            //Or we can print key and values as below:-
            foreach (DictionaryEntry city in collctionInitializer)  //A DictionaryEntry holds a key and a value from a dictionary.
            {
                Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
            }
            Console.WriteLine();

            //Contains
            Console.WriteLine("Is Name key exists in hashtable:" + hashtable.Contains("Name"));

            //ContainsKey
            Console.WriteLine("Is Salary key exists in hashtable:" + hashtable.ContainsKey("Salary"));

            //ContainsValue
            Console.WriteLine("Is Salary value exists in hashtable:" + hashtable.ContainsValue(null));

            //Remove

            // hashtable.Remove(null); //Unhandled exception. System.ArgumentNullException: Key cannot be null. (Parameter 'key')
            //at System.Collections.Hashtable.Remove(Object key)


            hashtable.Remove("Nickee"); //It will not throw any exception as key is not available in the Hashtable.
            hashtable.Remove("Location");
            Console.WriteLine("After removing key Location Hashtable elements are:- ");
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }
            Console.WriteLine();

            //Clear
            hashtable.Clear();
            Console.WriteLine("Total number of elements in hashtable is now: " + hashtable.Count);

            //Assigning Values to a Hashtable with Indexer
            Hashtable hashtable1 = new Hashtable();
            hashtable1[1] = "Gaby";
            hashtable1[2] = "Bree";
            hashtable1[3] = "Susan";
            foreach (DictionaryEntry dec in hashtable1)
            {
                Console.WriteLine($"Key: {dec.Key}, Value: {dec.Value}");
            }
            Console.WriteLine();

            //Updating a Hashtable using Indexer
            Hashtable emp = new Hashtable();
            emp.Add("Id", 1);
            emp.Add("Name", "Ragini");
            emp.Add("Salary", 100);
            emp.Add("Location", "BLR");
            emp.Add("EmailId", "abc@gmail.com");
            //emp.Add("EmailId", "abc@");

            emp["Name"] = "Zach";
            emp["Salary"] = 5000;

            //Accessing Hashtable elements using index
            string EmployeeName = (string)emp["Name"];
            int EmployeeSalary = (int)emp["Salary"];
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");
            Console.WriteLine();
        }
    }

}