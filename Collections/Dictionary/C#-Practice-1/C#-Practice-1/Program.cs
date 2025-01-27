using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> persons = new Dictionary<int, string>();
            persons.Add(2610, "Sina");
            persons.Add(2611, "Saeed");
            persons.Add(2612, "K1");
            persons.Add(2613, "Reza");
            foreach (var item in persons)
            {
                Console.WriteLine("key: " + item.Key + " Name: " + item.Value);
            }
            Console.WriteLine();

            SortedDictionary<int, string> persons2 = new SortedDictionary<int, string>();
            persons2.Add(210, "Sina");
            persons2.Add(201, "Saeed");
            persons2.Add(26, "K1");
            persons2.Add(263, "Reza");

            foreach (var item in persons2)
            {
                Console.WriteLine("key: " + item.Key + " Name: " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
