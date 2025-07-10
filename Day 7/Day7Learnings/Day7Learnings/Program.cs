using System.Security.Cryptography;

namespace Day7Learnings
{
    internal class Program
    {

        public static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"x: {x} and y: {y}");
        }

        public static int[] DoubleIt(int[] arr1, int[] arr2)
        {
            int n = Math.Max(arr1.Length, arr2.Length); 
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i >= arr1.Length)
                {
                    arr[i] = 0 + arr2[i];
                    
                }

                else if (i >= arr2.Length)
                {
                    arr[i] = arr1[i] + 0;
                    

                }
                else
                    arr[i] = arr1[i] + arr2[i];
                   
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 ,4,5,6,7};
            int[] arr2 = { 10, 20, 30 };
            int num1 = 10, num2 = 20;
            swap(num1, num2);
            Console.WriteLine($"num1: {num1} num2: {num2}");

            int[] arr3 = DoubleIt(arr1, arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }


            int[][] arr = new int[3][];
            arr[0] = new int[2] {1,2};
            arr[1] = new int[3] {1,2,3};
            arr[2] = new int[4] {1,2,3,4};

            foreach (int[] a in arr)
            {
                foreach(int b in a)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine("");
            }

            //int? i = null;

            //int j;
            //j = i ?? 10;

            string str = "sss";
            Object obj = str;

            if (str is int)
            {
                Console.WriteLine("the string is of type int");
            }
            else
            {
                Console.WriteLine("this string is not of type int");
            }

            Object[] myObj = new Object[3];
            myObj[0] = 10;
            myObj[1] = "str";
            myObj[2] = true;

            string s = myObj[0] as string;
            Console.WriteLine(s);

            string st = myObj[1] as string;
            Console.WriteLine(st);

            int t1;
            var t2 = 10;
            var t3 = "hello";
            var t4 = 'c';

            Console.WriteLine("------------DEMO-------------");
            Console.WriteLine("variable with var keywords: {0} {1} {2}",t2,t3,t4);

            dynamic t5;
            t5 = "new string";
            Console.WriteLine("variable with dynamic keywords: {0}",t5);
            t5 = 6;
            Console.WriteLine("variable with dynamic keywords: {0}", t5);
        }
    }
}
