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
            Dag dag = new Dag();
            dag.Walk();
            Console.ReadKey();
        }
    }

    public class Animal
    {
        public string WalkType { get; set; }
        public virtual void Walk()
        {
            Console.WriteLine("Fly");
        }
    }

    public class Dag : Animal
    {
        // Override
        public override void Walk()
        {
            Console.WriteLine("Walking");
        }

        //overloading
        public void PrintName()
        {
            Console.WriteLine("Sina");
        }

        public void PrintName(string name)
        {
            Console.WriteLine(name);
        }
        public void PrintName(string name,string lastName)
        {
            Console.WriteLine(name + " , "+ lastName);
        }
    }
}
