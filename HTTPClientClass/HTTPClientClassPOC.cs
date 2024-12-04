using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CSharp_Practice.HTTPClientClass
{
    public class HTTPClientClassPOC
    {

        static async Task Main()
        {
            HttpClient client = new HttpClient();
            string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/age-counting");
            Console.WriteLine(s);
            var parsed = JsonDocument.Parse(s);
            var dataString = parsed.RootElement.GetProperty("data").GetString();

            if (dataString != null)
            {
                var pairs = dataString.Split(", ");
                var items = new List<(string Key, int Age)>();

                for (var index = 0; index < pairs.Length; index += 2)
                {
                    if (index + 1 >= pairs.Length)
                        break;

                    var firstPair = pairs[index].Split("=");
                    var secondPair = pairs[index + 1].Split("=");

                    if (firstPair.Length != 2 || secondPair.Length != 2)
                        continue;

                    if (firstPair[0] != "key" || secondPair[0] != "age")
                        continue;

                    items.Add((Key: firstPair[1], Age: int.Parse(secondPair[1])));
                }

                var count = items.Count(x => x.Age >= 50);
                Console.WriteLine("Count is: " + count);
            }
        }

    }
}
