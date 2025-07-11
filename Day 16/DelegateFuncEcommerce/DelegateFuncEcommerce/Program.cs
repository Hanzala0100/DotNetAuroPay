using System;

namespace DelegateFuncEcommerce
{
    internal class Program
    {
        public static double couponDiscount = 10;
        public static double festivalDiscount = 20;
        public static double loyaltyDiscount = 20;


        static Func<double, double, double> applyDiscount = (price, discountPercent) =>
        {
            return  (price * discountPercent / 100);
        };

        static void Main(string[] args)
        {
            double price;
            Console.WriteLine("Enter the price of the product");
            price = double.Parse(Console.ReadLine());
            double OgPrice = price;

            while (true)
            {
                Console.WriteLine("Select the discount type:");
                Console.WriteLine("1. Coupon Discount");
                Console.WriteLine("2. Festival Discount");
                Console.WriteLine("3. Loyalty Discount");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        price -= applyDiscount(OgPrice, couponDiscount);
                        Console.WriteLine("Price after coupon discount: " + price);
                        break;
                    case 2:
                        price -= applyDiscount(OgPrice, festivalDiscount);
                        Console.WriteLine("Price after festival discount: " + price);
                        break;
                    case 3:
                        price -= applyDiscount(OgPrice, loyaltyDiscount);
                        Console.WriteLine("Price after loyalty discount: " + price);
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return;
                }
            }
        }
    }
}