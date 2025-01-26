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
            InputTypes<int,string> obj = new InputTypes<int,string>();
            // Error Type
            //obj.input1 = "Sina";
            // obj.input2 = 3;
            obj.Input1 = 44;
            obj.Input2 = "44";
            obj.Inputs = new int[] { 1, 2, 3 };
            var vals = obj.PrintType("name");
            Console.WriteLine(vals.GetType());
            Console.ReadKey();
        }
    }

    public class InputTypes<a, b>
    {
       public a Input1 { get; set; }
       public b Input2 { get; set; }
       public a[] Inputs;

       public b PrintType(b inputs)
       {
            return inputs;
       }
        
    }
}
