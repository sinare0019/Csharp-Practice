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
            Stack<string> names = new Stack<string>();
            names.Push("Sina");
            names.Push("Reza");
            names.Push("Hamid");
            foreach (var item in names)
            {
                // Last input => first outPut
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
