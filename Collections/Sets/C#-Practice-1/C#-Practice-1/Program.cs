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
            HashSet<string> names = new HashSet<string> { "Sina","Saeed","Reza","K1","Sina"};
            foreach (var item in names)
            {
                // no Repet
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
