using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persson person = new Persson();
            person.Create("Sina","Rezaei");
            Console.ReadKey();
        }
    }

    interface IPerson
    {
        void Create(string Name, string LastName);
        int Edit(string Name, string LastName);
    }

    public class Persson : IPerson
    {
        public void Create(string Name, string LastName)
        {
            Console.WriteLine(Name + " ," + LastName);
        }

        public int Edit(string Name, string LastName)
        {
            Console.WriteLine("Edit " + Name + " ," + LastName);
            return 0;
        }
    }
}
