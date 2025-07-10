using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class StudentManager
    {
        Student[] students = new Student[3];
        static int count = 0;

        public void AddStudent()
        {
            if(count >= students.Length)
            {
                Console.WriteLine("Capacity reached! ");
                return;
            }
            Console.WriteLine("Provide student details:");
            Console.Write("id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student(id,name,email,age);
            students[count++] = student;
            Console.WriteLine("Student Added Succesfully!");
        }

        public void DisplayStudent()
        {
            foreach(Student student in students)
            {
                if(student != null)
                {
                    Console.WriteLine("id: "+student.Id);
                    Console.WriteLine("name: "+student.Name);
                    Console.WriteLine("email: "+student.Email);
                    Console.WriteLine("age: "+student.Age);
                }

            }
        }

        public void EditStudent()
        {
            Console.WriteLine("which Student do you want to edit (id): ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach(Student student in students)
            {
                if(student!= null && id == student.Id)
                {
                    Console.WriteLine("Provide new details:");
                    Console.Write("Name: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Email: ");
                    student.Email = Console.ReadLine();
                    Console.Write("Age: ");
                    student.Age = int.Parse(Console.ReadLine());

                }
                else
                {
                    count++;
                }
            }

            if (count == students.Length)
            {
                Console.WriteLine("No such Id Exists!");
                return;
            }
        }

        public void CheckStudent()
        {
            bool exists = false;
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Student newStudent = new Student(1, name, email, 21);

            foreach(Student student in students)
            {
                if (student!=null && student.Equals(newStudent))
                {
                    Console.WriteLine("this student is duplicate");
                    exists = true;
                }
            }

            if(exists == false)
            { 
                Console.WriteLine("no duplicate exists");
            }

        }
    }
}
