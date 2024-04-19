using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Visitor
{
    public interface IProductVisitor
    {
        string Visit(Book book);
        string Visit(Electronic electronic);
        string Visit(Grocery grocery);
    }
}
