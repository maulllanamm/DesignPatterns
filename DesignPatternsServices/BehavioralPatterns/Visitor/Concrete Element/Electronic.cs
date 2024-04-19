namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public class Electronic : IProduct
    {
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Accept(IProductVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
