namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public class Book : IProduct
    {
        public double Price { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Accept(IProductVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
