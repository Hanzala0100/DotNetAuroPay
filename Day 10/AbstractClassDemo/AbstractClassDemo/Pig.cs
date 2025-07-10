using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("oink oink!");
        }

    }
}
