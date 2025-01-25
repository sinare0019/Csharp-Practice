using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person { Name = "Sina", LastName = "Rezaei", Age = 19 });
            person.Add(new Person { Name = "Hamed", LastName = "Mohebi", Age = 17 });
            person.Add(new Person { Name = "Milad", LastName = "Nori", Age = 21 });
            person.Add(new Person { Name = "Hosein", LastName = "Delir", Age = 15 });
            Dlg dlg = new Dlg(CheeckAge);
            Person.Register(person, dlg);
            Console.ReadKey();
        }

        public static bool CheeckAge(Person person)
        {
            if (person.Age >= 18)
                return true;
            else
                return false;
        }
    }
    public delegate bool Dlg(Person person);
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static void Register(List<Person> persons,Dlg dlgPerson)
        {
            foreach (var item in persons)
            {
                if (dlgPerson(item))
                {
                    Console.WriteLine("Name: " + item.Name + ", LastName: " + item.LastName + ", Age: " + item.Age);
                }
            }
        }
    }
}
