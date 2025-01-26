using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MessageEvent += BeforMessage;
            PrintMessage();
            Console.ReadKey();
        }

        public delegate void DlgBeforMessage();
        public static event DlgBeforMessage MessageEvent;

        public static void PrintMessage()
        {
            MessageEvent.Invoke();
            Console.WriteLine("WellCom");
        }

        public static void BeforMessage()
        {
            Console.WriteLine("Hi");
        }
    }
}
