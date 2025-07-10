using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeviceControl
{
    internal interface ITerestrial
    {
        void Eat();
        void Walk();
    }

    internal interface IAquatic
    {
        void Eat();
        void Swim();
    }

    internal class Crocodile : ITerestrial,IAquatic
    {

        public void Eat()
        {
            Console.WriteLine("Ate!");
        }

        public void Walk()
        {
            Console.WriteLine("Walked!");
        }

        public void Swim()
        {
            Console.WriteLine("Swam!");
        }

    }
}
