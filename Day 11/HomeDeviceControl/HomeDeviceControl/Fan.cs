using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeviceControl
{
    internal class Fan : ISwitchable, IStatusReportable
    {
        public bool status { get; set; }
        public void On()
        {
            status = true;
            Console.WriteLine("Fan is now ON!");
        }

        public void Off()
        {
            status = false;
            Console.WriteLine("Fan is now OFF!");
        }

        public void ReportStatus(string message)
        {
            if (status) 
            { 
                Console.WriteLine("The Fan is ON!"); 
                Console.WriteLine($"the Fan speed is: {message}"); 
            }
            else Console.WriteLine("The Fan is OFF!");


        }
    }
}
