using System.Drawing;

namespace HomeDeviceControl
{
    internal class Program
    {

        
        public static void AskUser()
        {
            Console.WriteLine("Fan or Light");
            string choice = Console.ReadLine();

            if (choice == "Fan")
            {
                Fan fan = new Fan();
                fan.On();
                fan.Off();
                fan.On();
                fan.ReportStatus("fast");

            }
            else
            {
                Light light = new Light();
                light.On();
                light.Off();
                light.On();
                light.ReportStatus("Dim");
            }
        }
        static void Main(string[] args)
        {
            AskUser();

            ITerestrial crocT = new Crocodile();
            crocT.Walk();
            crocT.Eat();

            IAquatic crocA = new Crocodile();
            crocA.Swim();
            crocA.Eat();
        }
    }
}
