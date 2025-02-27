using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
             Task.Run(() =>
            {
                for (int i = 0; i < 400; i++)
                {
                    Console.WriteLine("K1");
                }
            }).Wait();


            Task.Run(() =>
            {
                for (int i = 0; i < 400; i++)
                {
                    Console.WriteLine("Sina");
                }
            });

            Task.Run(() =>
            {
                for (int i = 0; i < 400; i++)
                {
                    Console.WriteLine("Saeed");
                }
            });


            Task.Run(() =>
            {
                for (int i = 0; i < 400; i++)
                {
                    Console.WriteLine("Reza");
                }
            });

            Console.ReadKey();
        }
    }
}
