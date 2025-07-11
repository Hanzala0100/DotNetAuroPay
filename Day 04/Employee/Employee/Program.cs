namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            employee1.EmpId(101);
            employee1.EmpName("Youbraj");

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            Console.WriteLine("Employee Id: {0}, Employee name: {1}, Company Name: {2}",employee1.EmpId(),employee1.EmpName(),Employee.companyName);
            Console.WriteLine("Employee count: "+Employee.empCount);
            Console.WriteLine("Customer count: " + Customer.customerCount);
            Console.WriteLine("StakeHolder count: "+ StakeHolder.stakeHolderCount);
        }
    }
}
