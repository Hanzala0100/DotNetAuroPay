using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;
        private bool isBestSeller;

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public double Price { get { return price; } set { price = value; } }
        public bool IsBestSeller { get { return isBestSeller; } set { isBestSeller = value; } }
        

        public static double CalculateDiscountedPrice( Book obj)
        {
            double discountedPrice = obj.price;
            //if book is best seller give 10% discount;
            if (obj.isBestSeller)
                discountedPrice =  obj.price - (obj.price * 0.1);

            //if price > 500 "additional" discount of 5%
            if(obj.price > 500 && obj.isBestSeller)
                discountedPrice = obj.price - (obj.price * 0.15);

            return discountedPrice;

        }

        
    }
}
