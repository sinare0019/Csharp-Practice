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
            Register register = new Register();
            register.RegisterBeforeHandler += RegisterBefore;
            register.RegisterUniversity("Sina",22);
            Console.ReadKey();
        }

        public static void RegisterBefore(int age)
        {
            Console.WriteLine("Age must be over 20.");
        }
    }

    public class Register
    {
        public delegate void DlgRegisterBefore(int age);
        public event DlgRegisterBefore RegisterBeforeHandler;
        public void RegisterUniversity(string name,int age)
        {
            RegisterBeforeHandler?.Invoke(age);
            Console.WriteLine(" "+name+" WellCom To University");
        }
    }
}
