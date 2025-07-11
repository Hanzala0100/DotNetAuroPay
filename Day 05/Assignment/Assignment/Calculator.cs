using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Calculator
    {
        public static double Add(int a,int b)
        {
            return a + b;
        }

        public static double Add(double a,double b)
        {
            return a + b;
        }

        public static int Add(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                Console.WriteLine("Invalid Input: array is null or empty.");
                return 0;
            }

            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}
