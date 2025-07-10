using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAbstract
{
    internal class Student : Person
    {
        public string Course {  get; set; }
        public int Age {  get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name} id:{Id} Course: {Course} Age:{Age}");
        }

        public Student(string name, int id, string course,int age): base(name, id)
        {
            Course = course;
            Age = age;
        }

    }
}
