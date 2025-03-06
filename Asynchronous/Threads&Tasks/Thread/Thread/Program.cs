using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(()=>GetNames("Sina"));
            Thread thread2 = new Thread(()=>GetNames("Saeed"));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

        public static void GetNames(string name)
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
