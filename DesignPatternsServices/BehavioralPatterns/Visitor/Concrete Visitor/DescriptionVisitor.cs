namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public class DescriptionVisitor : IProductVisitor
    {
        public string Visit(Book book)
        {
            return $"Book: {book.Title}, ISBN: {book.ISBN}";
        }
        public string Visit(Electronic electronic)
        {
            return $"Electronic: {electronic.Brand} {electronic.Model}";
        }
        public string Visit(Grocery grocery)
        {
            return $"Grocery: {grocery.Name}, Expires on: {grocery.ExpiryDate.ToShortDateString()}";
        }
    }
}
