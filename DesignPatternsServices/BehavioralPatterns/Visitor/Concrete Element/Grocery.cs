namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public class Grocery : IProduct
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Accept(IProductVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
