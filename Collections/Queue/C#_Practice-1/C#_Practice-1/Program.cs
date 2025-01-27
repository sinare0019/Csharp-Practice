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
            Queue<int> names = new Queue<int>();
            names.Enqueue(1);
            names.Enqueue(2);
            names.Enqueue(3);
            names.Enqueue(4);
            foreach (int i in names)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
