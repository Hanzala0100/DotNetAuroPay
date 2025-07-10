using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Dog : Animal
    {
        public Dog(string color, string breed) : base(color, breed) { }

        public override void EatsFood()
        {
            Console.WriteLine("Dog eats Bone!");
        }


        
    }
}
