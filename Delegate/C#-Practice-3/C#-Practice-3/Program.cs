using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_3
{
    public class Program
    {
      

        static void Main(string[] args)
        {
            Func<int, int, int> func = Subtract;
            Action<int> action = PrintNumbers;
            var result = func(4, 8);
            action(result);

            Predicate<int> prBool = ResultCheeck;
            Console.WriteLine(prBool(result));
            Console.ReadKey();
        }
      
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static void PrintNumbers(int resultNumber)
        {
            Console.WriteLine(resultNumber);
        }

        public static bool ResultCheeck(int number)
        {
            if (number > 0)
                return true;
            else
                return false;
        }
    }
}
