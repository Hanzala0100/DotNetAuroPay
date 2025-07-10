using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAbstract
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public abstract void DisplayDetails();

        public Person(string name, int id)
        {
            Name = name; Id = id;   
        }
    }
}
