namespace PubSubDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FireAlarm fireAlarm = new FireAlarm();
            fireAlarm.FireAlarmEvent += callFireSystem;
            fireAlarm.FireAlarmEvent += openExitDoors;

            fireAlarm.TriggerAlarm();

        }

        public static void callFireSystem()
        {
            Console.WriteLine("Fire alarm event received!");
        }

        public static void openExitDoors()
        {
            Console.WriteLine("Exit doors opened!");
        }
    }
}
