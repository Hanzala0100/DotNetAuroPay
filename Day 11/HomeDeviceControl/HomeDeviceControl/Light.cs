using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeviceControl
{
    internal class Light : ISwitchable,IStatusReportable
    {
        public bool status {  get; set; }
        public void On()
        {
            status = true;
            Console.WriteLine("Light is now ON!");
        }

        public void Off()
        {
            status = false;
            Console.WriteLine("Light is now OFF!");
        }

        public void ReportStatus(string message)
        {
            if (status)
            {
                Console.WriteLine("The Light is ON!");
                Console.WriteLine($"the Light is: {message}");
            }
            else Console.WriteLine("The light is OFF!");

            Console.WriteLine($"the light is: {message}");
        }
    }
}
