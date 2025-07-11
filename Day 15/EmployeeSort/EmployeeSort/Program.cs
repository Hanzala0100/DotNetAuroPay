

using Microsoft.Win32.SafeHandles;

namespace EmployeeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Carl", 103, 50000));
            list.Add(new Employee("Alice", 104, 60000));
            list.Add(new Employee("Bob", 102, 55000));
            list.Add(new Employee("Diana", 101, 70000));

            // select max salary from list uing linq query syntax




            var maxEmp = (from emp in list select emp.EmpSalary).Max();

            Console.WriteLine($"Maximum Salary: {maxEmp}");


            var minEmp = (from emp in list select emp.EmpSalary).Min();

            Console.WriteLine($"Minimum Salary: {minEmp}");

            var minEmployee = (from emp in list where emp.EmpSalary == minEmp select emp);


            foreach (var emp in minEmployee)
            {
                Console.WriteLine(emp.ToString());
            }

            // do same for averahge salary
            var avgEmp = (from emp in list select emp.EmpSalary).Average();
            Console.Write($"Average Salary: {avgEmp}");



            //List<int> intList = new List<int>();
            // intList.Add(1);
            // intList.Add(3);
            // intList.Add(2);
            // intList.Add(4);
            // intList.Add(7);



            // foreach (var emp in list)
            // {
            //     Console.WriteLine(emp.ToString());
            // }


            // Console.WriteLine("\nSorting employees by name...\n");

            // //list.Sort(Employee.compareBySalary);



            // foreach (var emp in list)
            // {
            //     Console.WriteLine(emp.ToString());
            // }

            // //DisplayIntList();

            // Console.WriteLine("\nSorting Integer List...\n");
            // intList.Sort((x,y)=> y.CompareTo(x));
            // DisplayIntList();

            // void DisplayIntList()
            // {
            //     foreach (int x in intList)
            //     {
            //         Console.WriteLine(x);
            //     }
            // }

            //List<String> FruitList = new List<String>();
            //FruitList.Add("Apple");
            //FruitList.Add("Banana");
            //FruitList.Add("PineApple");
            //FruitList.Add("Orange");
            //FruitList.Add("Mango");


            //Console.WriteLine("Fruits List before sorting:");

            //foreach (var fruit in FruitList)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Console.WriteLine("\nSorting Fruits List...\n");
            ////sort on the basis of length of string

            ////FruitList.Sort((x, y) => x.Length.CompareTo(y.Length));


            ////Query Syntax
            //var shortFruts =  from fruit in FruitList where fruit.Length < 6 && fruit.Contains('M') select (fruit,fruit.Length);
            ////Method Syntax
            ////var shortFruts = FruitList.Where(fruit => fruit.Length < 6 && fruit.Contains('M'));

            //foreach (var fruit in shortFruts)
            //{
            //    Console.WriteLine(fruit);
            //}

        }





    }
}
