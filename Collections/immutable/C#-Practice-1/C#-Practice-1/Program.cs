using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Sina");
            names.Add("Reza");
            names.Add("Saeed");

            var immu = names.ToImmutableList();
            immu.Add("K1");
            foreach (var item in immu)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
