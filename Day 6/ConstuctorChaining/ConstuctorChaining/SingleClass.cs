using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstuctorChaining
{
    internal class SingleClass
    {
        public SingleClass(int n) : this("s")
        {
            Console.WriteLine("in constructor 1");
        }

        public SingleClass() : this(100)
        {
            Console.WriteLine("in constructor 2");
        }

        public SingleClass(string str)
        {
            Console.WriteLine("in constrctor 3");
        }
    }
}
