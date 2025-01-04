using System.Numerics;

namespace CSharp_Practice.Collections.Generic.Dictionary
{
    public class DictionaryPOC
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("India", "Delhi");
            dic.Add("UK", "London");
            dic.Add("China", "Beijing");

            Console.WriteLine("Printing dictionary elements using foreach loop:-");
            foreach (KeyValuePair<string, string> keyValuePair in dic)
            {
                Console.WriteLine($"Key: {keyValuePair.Key}, Value: {keyValuePair.Value}");
            }
            Console.WriteLine();

            //Using for loop to access dictionary elements
            Console.WriteLine("Printing dictionary elements using for loop:-");
            for (int i = 0; i < dic.Count; i++)
            {
                string key = dic.Keys.ElementAt(i);
                string value = dic[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }
            Console.WriteLine();

            //Accessing dictionary elements using keys
            Console.WriteLine("Printing dictionary elements using keys:-");
            Console.WriteLine($"Key: India, Value: {dic["India"]}");
            Console.WriteLine($"Key: UK, Value: {dic["UK"]}");
            Console.WriteLine($"Key: China, Value: {dic["China"]}");
            Console.WriteLine();

            //Adding elements to a Dictionary using collection initializer 
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "UK", "London, Manchester" },
                { "India", "Delhi, Mumbai" },
            };
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                Console.WriteLine($"Key: {keyValuePair.Key}, Value: {keyValuePair.Value}");
            }
            Console.WriteLine();

            //ContainsKey
            if (dic.ContainsKey("India"))
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            Console.WriteLine();

            //ContainsValue
            if (dic.ContainsValue("Delhi"))
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value not found");
            }
            Console.WriteLine();

            //Remove
            if (dic.ContainsKey("India"))
            {
                dic.Remove("India");
                Console.WriteLine("Now dictionary's element count: " + dic.Count);
            }
            Console.WriteLine();

            //Clear
            if (dic.Keys != null)
            {
                dic.Clear();
            }
            Console.WriteLine("Dictionary's element count after using Clear method: " + dic.Count);
            Console.WriteLine();

            //Assigning values to a dictionary with indexer 
            dic["IND"] = "India";
            dic["Pak"] = "Pakistan";
            foreach (var item in dic)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
            Console.WriteLine();

            //Updating the key IND and Pak using indexer
            dic["IND"] = "Bharat";
            dic["Pak"] = "Eslamabad";
            Console.WriteLine($"IND: {dic["IND"]}");
            Console.WriteLine($"Pak: {dic["Pak"]}");
            //Console.WriteLine($"SLK: {dic["SLK"]}"); //It will throw: Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key 'SLK' was not
                                                     //present in the dictionary.
            Console.WriteLine();

            //Generic dictionary collection with complex type
            Dictionary<int, Student> complexDic = new Dictionary<int, Student>
            {
                 { 100, new Student(){Id = 100, Name = "Bree", Branch = "IT" } },
                 { 101, new Student(){Id = 101, Name = "Susan", Branch = "CSE" } },
                 { 102, new Student(){Id = 102, Name = "Gaby", Branch = "EEE" } }
            };
            foreach (KeyValuePair<int, Student> item in complexDic)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Adding more data into complexDic
            Student student1 = new Student();
            student1.Id = 103;
            student1.Name = "Mike";
            student1.Branch = "EE";
            Student student2 = new Student();
            student2.Id = 104;
            student2.Name = "Zach";
            student2.Branch = "Civil";

            complexDic.Add(student1.Id, student1);
            complexDic.Add(student2.Id, student2);
            foreach (KeyValuePair<int, Student> item in complexDic)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TryGetValue
            Student s1;
            if (complexDic.TryGetValue(100, out s1))
            {
                Console.WriteLine("Student with Key 100 is found in the dictionary");
                Console.WriteLine(s1.ToString());
            }
            else
            {
                Console.WriteLine("Student with Key 100 is not found in the dictionary");
            }

            Student s2;
            if (complexDic.TryGetValue(106, out s2))
            {
                Console.WriteLine("Student with Key 106 is found in the dictionary");
                Console.WriteLine(s2.ToString());
            }
            else
            {
                Console.WriteLine("Student with Key 106 is not found in the dictionary");
            }
            Console.WriteLine();

            //Converting an array to a dictionary
            Student[] arr = new Student[3];
            arr[0] = new Student() { Id = 200, Name = "Leenet", Branch = "ETC" };
            arr[1] = new Student() { Id = 201, Name = "Julee", Branch = "E&CS" };
            arr[2] = new Student() { Id = 202, Name = "Parker", Branch = "Mechanical" };

            Dictionary<int, Student> studentDic = new Dictionary<int, Student>();
            foreach (Student stu in arr)
            {
                studentDic.Add(stu.Id, stu);
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, Student> item in studentDic)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

}