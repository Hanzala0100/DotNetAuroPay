using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    public class Caculator
    {

        // two stqatic function add and substract
        public static void Add(int a, int b)
        {
            Console.WriteLine("Adding {0} and {1} : {2}",a,b,a+b);
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine("Subtracting {0} and {1} : {2}",a,b ,a - b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplying {0} and {1} : {2}",a,b ,a * b);
        }
        public static void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            Console.WriteLine("Dividing {0} by {1} : {2}",a,b, a / b);
        }
    }
}