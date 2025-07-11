using System.Threading;

namespace Threading_Demo
{
    internal class Program
    {
       static Boolean flag = true;
        // create locker object
        //to synchronize access to shared resources
        static readonly object locker = new object();

        static void Main(string[] args)
        {

            //Thread thread2 = new Thread(() => Mainb("Hello from thread 2"));
        
            //thread2.Start();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Main: " + i);
            //}


            //Thread thread1 = new Thread(() => Mainb("Hello from thread 1"));
            //thread1.Start();

            //Mainb();
            //Thread thread = new Thread(Mainb);
            //thread.Start()
            //Thread thread1 = new Thread(() => Mainb("Hello from thread 1"));
            // thread1.Start();
            // Thread thread2 = new Thread(() => Mainb("Hello from thread 2"));
            // thread2.Start();
            Thread threadGo = new Thread(Go1);
            threadGo.Name = "Go1Thread";
            threadGo.Start();
            threadGo.Join(); 


            Thread.CurrentThread.Name = "MainThread";
            Go1();

        }
        static void Mainb(string info)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("MainB: " + i + info);
                Thread.Sleep(1000);
            }
        }

        static void Go1()
        {

            Console.WriteLine("Go1: Thread started, current thread name: " + Thread.CurrentThread.Name);

            lock (locker)
            {
                if (flag)
                {
                    Console.WriteLine("Go1: Flag is true, setting to false. by: " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                    flag = false;
                }
            }
        }
    }
}
