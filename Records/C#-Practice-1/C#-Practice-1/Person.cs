using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1
{
    public record Person(string Name,string LastName);
    public record Register
    {
        public string Name { get; init; }
        public string LastName { get; init; }
        public int Age { get; init; }
    }
}
