using System.Text.RegularExpressions;

namespace UnderstandingRegex
{
    internal class Program
    {

        public static void isValid(string email)
        {
            string pattern = @"[a-zA-Z0-9_]+\@(example.com)$";
            bool isValid = Regex.IsMatch(email, pattern);
            if (isValid) Console.WriteLine(email);
            else Console.WriteLine("false");
        }

        public static void ExtractNumbers(string str)
        {
            string pattern = @"-?\d+(\.\d+)?";
            MatchCollection mathes = Regex.Matches(str, pattern);
            foreach (Match m in mathes)
            {
                Console.WriteLine(m);
            }
        }

        public static void PasswordChecker(string password)
        {
            bool isStrong;

            if(password.Length > 8)
            {
                isStrong = true;
            }

            isStrong = Regex.IsMatch(password, @"[A-Z]");
            isStrong = Regex.IsMatch(password, @"[a-z]");
            isStrong = Regex.IsMatch(password, @"[0-9]");
            isStrong = Regex.IsMatch(password, @"[_!\@#\$]");

            if (isStrong) Console.WriteLine("Strong");
            else Console.WriteLine("Weak!");

        }
        static void Main(string[] args)
        {
            string str = "87989080";
            string pattern = @"^\d+$";
            bool isNumber = Regex.IsMatch(str, pattern);

            if (isNumber) Console.WriteLine("it is only number");
            else Console.WriteLine("no number");

            string email = "user@@example.com";
            isValid(email);


            ExtractNumbers("my age is 21 and my height is 5.4");

            PasswordChecker("jhgjkhk7988");
        }
    }
}
