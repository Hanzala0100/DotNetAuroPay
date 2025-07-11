class AmusementParkBill
{

    static int CalculateBill(in int Height, in int Age)
    {
        int Bill = 0;

        if(Height < 120)
            return 0;

        if (Age < 12)
        {
            Bill += 5;
        }
        else if (Age >= 12 && Age <= 18)
        {
            Bill += 7;
        }
        else if(Age > 18 )
        {
            Bill += 12;
        }
        else if( Age >= 45 && Age<=55)
        {
            Bill += 0;
        }
        else
        {
            return 0;
        }

        Console.Write("Do you want Photos (YES or NO): ");
        string wantPhotos = Console.ReadLine();

        if(wantPhotos == "YES")
        {
            return Bill += 3;
        }
        else if(wantPhotos == "NO")
        {
            return Bill;
        }
        else
        {
            Console.WriteLine("Wrong Input");
            return 0;
        }

    }
    public static void Main(string[] args)
    {
        Console.Write("Please Enter your Height: ");
        int.TryParse(Console.ReadLine(), out int Height);
        Console.Write("Please Enter your Age: ");
        int.TryParse(Console.ReadLine(), out int Age);

        int bill = CalculateBill(Height, Age);

        if(bill == 0)
        {
            Console.WriteLine("Sorry Cant Ride");
            return;
        }
        else
        {
            Console.WriteLine("Your total Bill is: "+ bill);
        }
            
        



    }
}