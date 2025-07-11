using System.Globalization;

namespace ParallelForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };

            //Parallel.For(0, num, options, i =>
            //{
            //    Console.WriteLine($"Processing item {i} on thread {Thread.CurrentThread.ManagedThreadId}");
            //});


            //Parallel.ForEach(Enumerable.Range(0, num), options, i =>
            //{
            //    Console.WriteLine($"Processing item {i} on thread {Thread.CurrentThread.ManagedThreadId}");
            //});


            int[] array = [111, 222, 333, 444, 555, 666, 777, 888];

            Parallel.ForEach(array,options, ele =>
            {

                ProcessItem(ele);
                Console.WriteLine($"Processing item {ele} on thread {Thread.CurrentThread.ManagedThreadId}");
            }
            );

            //ProcessItem with foreach

            foreach (int ele in array)
            {
                ProcessItem(ele);
                Console.WriteLine($"Processing item {ele} on thread using ForEach Normal One {Thread.CurrentThread.ManagedThreadId}");
            }
)
        }
        static int ProcessItem(int item)
        {
            //Console.WriteLine($"Processing item {item} on thread {Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep(3000);
            return item * item;
        }
    }
}
