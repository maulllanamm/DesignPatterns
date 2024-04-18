using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Adapter.Adaptee
{
    public class PayPalPayment
    {
        public string MakePaymentWithPayPal(double amount)
        {
            return $"Processing PayPal payment of ${amount}";
        }
    }
}
