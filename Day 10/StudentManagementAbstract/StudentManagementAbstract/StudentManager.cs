using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAbstract
{
    internal class StudentManager
    {
        static int count = 0;
        Student[] students = new Student[3];

        public static Student TakeDetails()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Course: ");
            string course = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Student student = new Student(name, id, course, age);

            return student;
        }

        public static void CheckStudents()
        {
            if (count == 0)
            {
                Console.WriteLine("no student to display");
                return;
            }
        }

        public void AddStudent()
        {
            if(count == students.Length)
            {
                Console.WriteLine("Limit Reached!");
                return;
            }
            Student student = TakeDetails();
            students[count++] = student;
            Console.WriteLine("Student added!");
        }

        public void ViewStudents()
        {
            CheckStudents();

            foreach(Student student in students)
            {
                if(student != null)
                {
                    student.DisplayDetails();
                }
            }
        }

        public void UpdateStudent()
        {
            CheckStudents();
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            bool exist = false;
            foreach(Student student in students)
            {
                if( student != null && student.Id == id)
                {
                    Student newStudent = TakeDetails();
                    student.Age = newStudent.Age;
                    student.Name = newStudent.Name;
                    student.Course = newStudent.Course;

                    exist = true;
                }
            }

            if (exist == false)
            {
                Console.WriteLine("there is no student of this id: "+id);
            }
        }

        public void DeleteStudent()
        {
            CheckStudents();
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            bool exist = false;
            int index = 0;
            for(int i = 0; i < count; i++)
            {
                if (students[i] !=null && students[i].Id == id)
                {
                    index = i;
                    Console.WriteLine("index :"+index);
                    exist = true;
                    break;
                }
            }

            if (exist == false)
            {
                Console.WriteLine("there is no student of this id: "+id);

            }

            for (int i=index; i<count; i++)
            {
                if (i+1 == students.Length)
                {
                    students[i] = null;
                }
                else
                {
                    students[i] = students[i + 1];

                }
            }
            count--;
        }
    }
}
