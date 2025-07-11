using System.Security.Cryptography.X509Certificates;

namespace Delegate_Demo
{
    internal class Program
    {
        public delegate void MathsOps(int a, int b);
        static void Main(string[] args)
        {
            MathsOps myMath = new MathsOps(Caculator.Add);
            MathsOps myMath1 = new MathsOps(Caculator.Substract);
            MathsOps myMath2 = new MathsOps(Caculator.Divide);
            MathsOps myMath3 = new MathsOps(Caculator.Multiply);



            myMath(10, 20);
            myMath1(10, 20);
            myMath2(100, 20);
            myMath3(10, 20);

            //Multicast delegate
            Console.WriteLine("-------------------Multicast Delegate Demo----------------");
            MathsOps myMath4 = myMath + myMath1 + myMath2 + myMath3;
            myMath4(10, 20);


            myMath4 -= myMath1;
            Console.WriteLine("-------------------Multicast Delegate Demo after removing Substract----------------");
            myMath4(10, 20);

            Console.WriteLine("-------------------Multicast Delegate Demo after adding Divide----------------");
            myMath4 = myMath4 + new MathsOps(Caculator.Divide);
            myMath4(20, 10);

            var obj = new { Name= "John", Age = 30, City = "New York"};

            Console.WriteLine("_____________anonymous _______");


            myMath4 = delegate (int a, int b)
            {
                Console.WriteLine($"The sum is anonymous {a+b}");
            };

            myMath4(20, 30);

            Console.WriteLine("_____________Lambda _______");

            myMath += (a, b) =>  Console.WriteLine($"Sum from lambda {a + b}");

            myMath4(20, 30);



        }
    }
}
