namespace Assignment
{
    internal class Program
    {
        //this is example of static instance
        // this is also called as singleton pattern 
        // this is used when only 1 instance is needed of a object like here we only need 1 printer or 1 logger hence static instance is used
        class Printer
        {
            // This is the static instance (one shared object of Printer)
            public static Printer Instance = new Printer();

            // Make the constructor private so no one else can create objects
            private Printer() { }

            // A simple method to "print" a message
            public void PrintMessage(string message)
            {
                Console.WriteLine("Printer: " + message);
            }
        }

        //static variable and constructor
        //this variable is shared by all the instances of the object its common to all.
        //below code counts the number of instances created.
        //It also has Constructor : Constructors are methods that have same name as that of its class and are called automatically when an instance of the class is created.

        class Counter
        {
            public static int count = 0;

            public Counter()
            {
                count++;
            }
        }

        //static constructor only has static variables and is only called once the first time when the class object is used.
        class MyClass
        {
            public static int MyStaticNumber;

            // Static constructor
            static MyClass()
            {
                Console.WriteLine("Static constructor called!");
                MyStaticNumber = 10;
            }

            public static void ShowNumber()
            {
                Console.WriteLine("Static Number = " + MyStaticNumber);
            }
        }

        static void Main(string[] args)
        {
            Printer.Instance.PrintMessage("Hello, world!");
            Printer.Instance.PrintMessage("Another message!");

            Counter c1 = new Counter();
            Counter c2 = new Counter();
            Console.WriteLine(Counter.count);

            MyClass.ShowNumber();
            MyClass.ShowNumber();
        }
    }
}
