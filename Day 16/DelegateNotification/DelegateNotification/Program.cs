using System;
using System.Reflection.Metadata.Ecma335;

namespace DelegateNotification
{
    //now every function that goes in this delegate must be type void.
    public delegate void Notify();

    public class Program
    {
        public static void SendEmail()
        {
            Console.WriteLine("The message is sent from Email");
        }
        public static void SendSMS()
        {
            Console.WriteLine("The message is sent from SMS");
        }
        public static void SendPushNotification()
        {
            Console.WriteLine("The message is sent from push Notification");
        }

        public static void ShowNotification(Notify notifyDelegate)
        {
            notifyDelegate();
        }
        public static bool isUpper(string str)
        {
            return str == str.ToUpper();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static string printDetails(string Name, int age)
        {
            return $"The Name is : {Name}. The age is {age}";
        }
        public static void printDetailsVoid(string Name, int age)
        {
            Console.Write( $"The Name is : {Name}. The age is {age}");
        }
        public  static void Main(string[] args)
        {
            //Notify notify = null;

            //Console.WriteLine("Choose notifications to send (comma separated):");
            //Console.WriteLine("1. Email");
            //Console.WriteLine("2. SMS");
            //Console.WriteLine("3. Push Notification");
            //Console.Write("Enter your choice: ");
            //string input = Console.ReadLine();

            //if (input.Contains("1")) notify += SendEmail;
            //if (input.Contains("2")) notify += SendSMS;
            //if (input.Contains("3")) notify += SendPushNotification;

            //ShowNotification(notify);

            //while (true)
            //{
            //    Console.WriteLine("Choose notifications to send (comma separated):");
            //    Console.WriteLine("1. Email");
            //    Console.WriteLine("2. SMS");
            //    Console.WriteLine("3. Push Notification");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");
            //    string input = Console.ReadLine();
            //    switch (input)
            //    {
            //        case "1":
            //            notify += SendEmail;
            //            break;
            //        case "2":
            //            notify += SendSMS;
            //            break;
            //        case "3":
            //            notify += SendPushNotification;
            //            break;
            //        case "4":
            //            return;
            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            continue;
            //    }

            //    ShowNotification(notify);

            //    //delegate is like a bucket where we put functions to call them later



            //what is predicate Delegate ? answer: it return just bool vals
            //Predicate<string> isUpp = isUpper;
            //bool result = isUpp("HELLO WORLD");
            //Console.WriteLine($"Is the string uppercase? {result}");



            // func can take parameters and return a value
            // here first 2 are the parameters and last is the return type.

            //Func<int, int ,int> func = (x, y) => x + y;

            //Func<int, int, int> func2 = Sum;

            //int result = func(5, 10);
            //Console.WriteLine(result);
            //int result2 = func2(5, 10);
            //Console.WriteLine(result2);


            //Func<string, int, string> myDetails = printDetails;

            //Console.WriteLine(myDetails("Hanzala",22));

            //Action delegate is used where there is void reutrn type

            Action<string,int> myDetails = printDetailsVoid;
            myDetails("Hanzala", 21);
            
            //myDetails += printDetailsVoid;
            Console.WriteLine("");
            myDetails("BA", 2);

        }
    }
    }
