using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancelToken
{
    public class Program
    {
        static async void Main(string[] args, CancellationToken cancellation)
        {
            await Test(cancellation);
            Console.ReadKey();
        }

        public static async Task Test(CancellationToken cancellation)
        {
            Console.WriteLine("Test", cancellation);
        }
    }
}
