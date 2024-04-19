namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public interface IProduct
    {
        string Accept(IProductVisitor visitor);
    }
}
