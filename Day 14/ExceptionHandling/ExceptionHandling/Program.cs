namespace ExceptionHandling
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            int[] arr = { 10, 20, 30, 40 };


            try
            {
                if (num1 % 2 != 0)
                {
                    throw new OddNumberException("THe number is OPdd");
                }
                Console.WriteLine("The division is: ", num1 / num2);
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (DivideByZeroException ex)

            {
                Console.WriteLine(ex.StackTrace);

            }
            catch (OddNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Index out of bounds");
            }
            finally
            {
                Console.WriteLine("Finally !!");
            }

        }
    }



    public class OddNumberException : Exception  
    {
        public OddNumberException(string message) : base(message) { }
    }

}

