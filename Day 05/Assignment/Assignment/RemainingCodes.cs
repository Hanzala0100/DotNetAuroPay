using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class RemainingCodes
    {
        //print fibonacci series upto n elements
        public static void fibo(int count)
        {
            int currNumber = 0, nextNumber = 1;

            Console.Write(currNumber + " " + nextNumber + " ");
            do
            {
                int temp = currNumber + nextNumber;
                currNumber = nextNumber;
                nextNumber = temp;
                Console.Write(temp + " ");
                count--;

            } while (count != 0);
        }

        //print the number of spaces in the string
        public static void PrintSpacesNumber(string str)
        {
            int count = 0;
            foreach(char c in str)
            {
                if(c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        //Armstrong number has been done

        //reverse a number and check if its palindrome or not
        public static void ReverseNumber(int number)
        {
            int savedNumber = number;
            int reverse = 0;
            while(number > 0)
            {
                int temp = number%10;
                reverse = reverse * 10 + temp;
                number /= 10;
            }
            
            Console.WriteLine(reverse);

            if(savedNumber == reverse)
            {
                Console.WriteLine($"{savedNumber} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{savedNumber} is not a Palindrome");

            }

        }

        //fees of 5 students
        public static double[] Fees()
        {
            int numberOfStudents = 5;
            double[] feesOfStudents = new double[numberOfStudents];
            for(int i = 0;i< numberOfStudents;i++)
            {
                Console.Write($"Enter fees for Student{i+1}: ");
                feesOfStudents[i] = double.Parse(Console.ReadLine());

                if (feesOfStudents[i] < 5000 || feesOfStudents[i] > 10000)
                {
                    Console.WriteLine("Error! Fees must be in the range of 5000 and 10000");
                    if(i == 0)
                    {
                        i = -1;
                    }
                    else
                        i--;
                    
                }

                if (i >= 0 && feesOfStudents[i] >= 7000 )
                {
                    double discount = feesOfStudents[i] * 0.05;
                    feesOfStudents[i] -= discount; 
                }
            }

            Console.WriteLine("The fees with discount are: ");

            for(int i = 0; i< numberOfStudents; i++)
            {
                Console.WriteLine($"Student {i+1} fees: {feesOfStudents[i]}");
            }

            return feesOfStudents;
        }

    }
}
