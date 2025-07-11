namespace LearningClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.EmpId = 1;
            emp1.EmpName = "Youbraj";
            Designations designation = Designations.PRESIDENT;
            Console.WriteLine(emp1.ToString());
            Employee employee2 = new Employee(2,"Rohan",designation);
            Console.WriteLine(employee2.ToString());
            Employee emp3 = new Employee(employee2);
            Console.WriteLine(emp3.ToString());
            emp3.SalaryDistribution();

            Employee.CheckBonus(emp1 );
        }
    }
}
