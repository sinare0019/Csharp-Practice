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
            Print print = new Print();
            print.MessageEvent += BeforMessage;
            print.PrintMessage();
            Console.ReadKey();
        }

        public static void BeforMessage()
        {
            Console.WriteLine("Hi");
        }
    }

    //Publisher
    public class Print
    {
        public delegate void DlgBeforMessage();
        public event DlgBeforMessage MessageEvent;

        public void PrintMessage()
        {
            //if (MessageEvent != null)
              //  MessageEvent();
            MessageEvent?.Invoke();
            Console.WriteLine("WellCom");
        }
    }
}
