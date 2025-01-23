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
            Childs child = new Childs("Reza", "Sosan", "Sina", "Rezaei", 27);
            Console.WriteLine("dad: " + child.FatherName + " Mom: " + child.MotherName);
            Console.WriteLine("Name: " + child.Name + " LastName: " + child.LastName + " Age: " + child.Age.ToString());
        }
    }

    // sub class
    public class Family
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }
    }

    // child class
    public sealed class Childs : Family
    {
        public Childs(string fatherName, string motherName, string name, string lastName, int age)
        {
            FatherName = fatherName;
            MotherName = motherName;
            Name = name;
            LastName = lastName;
            Age = age;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    // Error becose Childs is Sealed
    // public class Test: Childs

}
