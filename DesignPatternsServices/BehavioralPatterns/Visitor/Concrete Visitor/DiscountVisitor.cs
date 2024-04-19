using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public class DiscountVisitor : IProductVisitor
    {
        public double DiscountedPrice { get; private set; } = 0;
        public string Visit(Book book)
        {
            DiscountedPrice = book.Price * 0.9;
            return DiscountedPrice.ToString();
        }

        public string Visit(Electronic electronic)
        {
            DiscountedPrice = electronic.Price * 0.95;
            return DiscountedPrice.ToString();
        }
        public string Visit(Grocery grocery)
        {
            DiscountedPrice = grocery.Price;
            return DiscountedPrice.ToString();
        }
    }
}
