using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.log().AddLog();
            Log.log().AddLog();
            Console.ReadKey();
        }
    }

    public class Log
    {
        private static Log _log;
        public static Log log()
        {
            if( _log == null )
                _log = new Log();
            return _log;
        }

        public void AddLog()
        {
            Console.WriteLine("Save Log");
        }
    }
}
