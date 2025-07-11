using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Animal
    {
        public string Color {  get; set; }
        public string Breed { get; set; }

        public Animal(string color,string breed)
        {
            this.Color = color;
            this.Breed = breed;
        }

        public virtual void EatsFood()
        {
            Console.WriteLine("Animal can be Herbivore or Carnivore!");
        }

        public override string ToString()
        {
            string str = $"breed: {this.Breed} color: {this.Color}";
            return str ;
        }
    }
}
