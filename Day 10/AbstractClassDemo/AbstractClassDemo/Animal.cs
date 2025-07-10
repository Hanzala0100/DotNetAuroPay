using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract class Animal
    {
        public abstract void animalSound();

        public void Sleep()
        {
            Console.WriteLine("zzzz!");
        }
    }

}
