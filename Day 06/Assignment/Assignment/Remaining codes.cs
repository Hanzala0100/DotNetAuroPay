using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Remaining_codes
    {
        public static void LargestOfThree(int num1, int num2, int num3)
        {
            if(num1 < num2)
                if(num2 < num3) Console.WriteLine(num3);
                else Console.WriteLine(num2);
            else 
                if(num1 > num3) Console.WriteLine(num1);
                else Console.WriteLine(num3);   
        }

        public static void MultiplicationTable(int n)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n*i}");
            }
        }
    }
}
