using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Cat : Animal
    {
        public Cat(string color,string breed) : base(color,breed) { }

        public override void EatsFood()
        {
            Console.WriteLine("Cat eats Fish!");
        }
    }
}
