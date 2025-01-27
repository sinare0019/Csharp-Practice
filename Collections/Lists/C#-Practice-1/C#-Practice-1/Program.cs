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
            List<string> listNames = new List<string>();
            listNames.Add("Sina");
            listNames.Add("Hamed");
            listNames.Add("Saeed");
            listNames.Add("Hosein");

            listNames.Sort();
            foreach (var item in listNames)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
