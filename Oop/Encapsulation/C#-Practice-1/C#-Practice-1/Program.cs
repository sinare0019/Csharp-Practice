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
            Person person = new Person();
            person.Name = "Sina";
            person.Age = 17;
            Console.WriteLine(person.Name + " ," + person.Age);
            Console.ReadKey();
        }
    }

    public class Person
    {
       private string name;
       private int? age;
        public string Name { get { return name; } set { name = value; } }
        public int? Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
    }
}
