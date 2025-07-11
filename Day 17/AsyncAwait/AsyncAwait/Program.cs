using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            await compexTask();
            Console.WriteLine("Main method completed.");

            int result = await MethodReturnsInt();
            Console.WriteLine($"Result from MethodReturnsInt: {result}");
        }

        static  async Task compexTask()
        {
            Console.WriteLine("Starting Complex Task...");
            await Task.Delay(1000); 
            Console.WriteLine("Complex Task Completed");
        }

        static async Task<int> MethodReturnsInt()
        {
            Console.WriteLine("MethodReturnsInt started.");
            await Task.Delay(500); 
            return 45;
        }
    }
}
