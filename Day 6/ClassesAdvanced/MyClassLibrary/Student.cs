using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }


        public Student(int id, string name, string email, int age)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
        }

        public override string ToString()
        {
            string str = $"id: {Id} name: {Name} age: {Age} email: {Email}";
            return str;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(!(obj is Student)) return false;

            return this.Name == ((Student)obj).Name && this.Email == ((Student)obj).Email;
        }
    }
}
