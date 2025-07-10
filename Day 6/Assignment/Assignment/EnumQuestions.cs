using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    enum DaysOfWeek { MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY}
    enum TrafficLight { RED , YELLOW , GREEN }
    enum Planet 
    { 
        MERCURY = (int)(0.38 * 100),
        VENUS = (int)(0.91 * 100),
        EARTH = (int)(1.00 * 100),
        MARS = (int)(0.37 * 100),
        SATURN = (int)(2.34 * 100),
        JUPITER = (int)(1.06 * 100),
        URANUS = (int)(0.92 * 100),
        NEPTUNE = (int)(1.19 * 100),
    }
    internal class EnumQuestions
    {
        
        public static void Week(int num)
        {
            DaysOfWeek day = DaysOfWeek.SUNDAY;
            switch (num)
            {
                case 1: day = DaysOfWeek.MONDAY; break;
                case 2: day = DaysOfWeek.TUESDAY; break;
                case 3: day = DaysOfWeek.WEDNESDAY; break;
                case 4: day = DaysOfWeek.THURSDAY; break;
                case 5: day = DaysOfWeek.FRIDAY; break;
                case 6: day = DaysOfWeek.SATURDAY; break;
                case 7: day = DaysOfWeek.SUNDAY; break;
                default: Console.WriteLine( "wrong output!");break;
            }
            Console.WriteLine(day);
        }

        public static void TrafficActions(TrafficLight light)
        {
            switch (light)
            {
                case (TrafficLight.RED): Console.WriteLine("STOP!");break;
                case TrafficLight.YELLOW: Console.WriteLine("READY!");break;
                case TrafficLight.GREEN: Console.WriteLine("GO!");break;
                default: Console.WriteLine("invalid input!");break;
            }
        }

        public static void GravityCalc(double weightOnEarth)
        {
            foreach(Planet planet in Enum.GetValues(typeof(Planet)))
            {
                double relativeGravity = (double)planet / 100;
                double equivWeight = weightOnEarth * relativeGravity;
                Console.WriteLine($"Weight on {planet}: {equivWeight} kg");
            }
        }

    }
}
