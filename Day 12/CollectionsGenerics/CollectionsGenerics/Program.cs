using System.Collections.Generic;
using System.Security.Cryptography;

namespace CollectionsGenerics
{
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            bool flag = true;
            for(int i = 2; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag; ;

        }

        public static void PrimeList()
        {
            List<int> list = new List<int>();
            Console.Write("How many numbers to add: ");
            int n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
                n--;
            }

            foreach(int num in list)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
        }

        public static int CountOccurance(char a,string str)
        {
            int count = 0;
            foreach(char c in str)
            {
                if(c == a)
                {
                    count++;
                }
            }

            return count;
        }

        public static void OccuranceList()
        {
            List<string> list = new List<string>();
            Console.Write("How many strings to add: ");
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Console.Write("Enter string: ");
                string str = Console.ReadLine();

                list.Add(str);
                n--;
            }
            Console.Write("what char to count: ");
            char ch = char.Parse(Console.ReadLine());
            foreach(string str in list)
            {
                Console.WriteLine($"{str} : {CountOccurance(ch,str)}");
            }
        }



        static void Main(string[] args)
        {
            //PrimeList();
            OccuranceList();
        }
    }
}
