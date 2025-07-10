namespace Assignment
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            Society society = new Society();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add Apartment");
                Console.WriteLine("2. Check Bill");
                Console.WriteLine("3. Change Rate");
                Console.WriteLine("4. exit");

                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1: society.AddApartment();
                        break;
                    case 2: society.CheckBill();
                        break;
                    case 3: society.ChangeRate(); 
                        break;
                    case 4: flag = false; 
                        break;
                    default: Console.WriteLine("Wrong input!");
                        break;
                }

                if (!flag)
                {
                    Console.WriteLine("thanks for joining!");
                }
            }
        }
        static void Main(string[] args)
        {
            /**
             * TODO:
             * Electricity billing application
             * for residential appartment complex
             * each apartment has its own meter
             * cost per unit is fixed across all the apartments
             * 
             * ElectricityBill
             * apartmentNumber
             * unitsConsumed
             * static costPerUnit
             * 
             * 
             * method to caluculate the bill amount
             * static method to change cost per unit
             * static method to display the current rate
             * instance method to display current bill
            **/

            DisplayMenu();
            
        }
    }
}
