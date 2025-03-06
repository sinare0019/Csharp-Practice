using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locks
{
    internal class Program
    {
        static string relativePath = "file1.txt";
        static string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        static string fullPath = Path.Combine(projectDirectory, relativePath);

        static object obj = new object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => AddTextFile("Test 1"));
            Thread thread2 = new Thread(() => AddTextFile("Test 2"));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

        public static void AddTextFile(string message)
        {

            lock (obj)
            {
                File.AppendAllText(fullPath, message);
            }

        }
    }
}





