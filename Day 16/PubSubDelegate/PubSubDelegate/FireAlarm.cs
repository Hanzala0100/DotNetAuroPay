using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubDelegate
{
    internal class FireAlarm
    {
        public delegate void FireAlarmHandler();
        public event FireAlarmHandler FireAlarmEvent;

        public void TriggerAlarm()
        {
            Console.WriteLine("Fire alarm triggered!");
            FireAlarmEvent();
        }
    }
}
