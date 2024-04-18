using DesignPatternServices_.StructuralPatterns.Facade.Subsytem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Facade
{
    public class Order
    {
        public string PlaceOrder()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Place order started");

            var product = new Product();
            stringBuilder.AppendLine(product.GetProductDetail());

            var payment = new Payment();
            stringBuilder.AppendLine(payment.MakePayment());

            var invoice = new Invoice();
            stringBuilder.AppendLine(invoice.SendInvoice());

            stringBuilder.AppendLine("Order Place Successfully");

            return stringBuilder.ToString();

        }
    }
}
