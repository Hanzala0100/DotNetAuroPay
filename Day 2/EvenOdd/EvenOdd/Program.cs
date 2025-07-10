class Program
{
    static string CheckEvenOdd(int number)
    {
        return (number % 2 ==0)?"even":"odd";
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide a Number");

        int number =Convert.ToInt32(Console.ReadLine());

        //if (CheckEvenOdd(number))
        //    Console.WriteLine("the number {0} is even",number);
        //else
        //    Console.WriteLine("the number {0} is odd",number);
        Console.WriteLine(CheckEvenOdd(number));

        int [] arr = new int[10];

        int sum = 0;

        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }   
        Console.WriteLine("sum of all the numbers are: " + sum);
    }
}