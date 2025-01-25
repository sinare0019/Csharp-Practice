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
            Dlg dl = new Dlg(PrintName);
            dl("Sina");

            dl += new Dlg(PrintMessage);
            dl("Reza");

            dl -= new Dlg(PrintName);
            dl("Hasan");
            Console.ReadKey();
        }

        public delegate void Dlg(string family);

        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public static void PrintMessage(string name)
        {
            Console.WriteLine(name+"is WellCome");
        }
    }
}
