namespace Calculator
{
    internal class Program
    {

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }

        static int Divide(int a, int b)
        {
            if (b!=0)
            return a / b;
            
            return 0;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Calculator  ");
            Console.Write("Enter Number 1: ");
            int num1 =int.Parse( Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Enter Number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            bool exit = false;


            while (!exit)
            {
                Console.WriteLine("choose\n 1: Addition \n 2: Substraction \n 3:Division \n 4: Multiplication \n 0:exit");
                int choice = int.Parse( Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("The Addition of {0} and {1} is: {2}",num1,num2,Add(num1, num2));
                        break;
                    case 2: Console.WriteLine("The Substraction of {0} and {1} is: {2}", num1, num2, Substract(num1,num2));
                        break;
                    case 3: Console.WriteLine("The Division of {0} and {1} is: {2}", num1, num2, Divide(num1,num2));
                        break;
                    case 4: Console.WriteLine("The Multiplication of {0} and {1} is: {2}", num1, num2, Multiply(num1,num2));
                        break;
                    case 0: exit = true;
                        break;
                    default: Console.WriteLine("wrong input");
                        break;

                }
            }


        }
    }
}
