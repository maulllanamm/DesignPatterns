using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternServices_.StructuralPatterns.Adapter.Adaptee;

namespace DesignPatternServices_.StructuralPatterns.Adapter.Adapter
{
    public class PayPalAdapter : IPaymentGateway
    {
        private readonly PayPalPayment _payPalPayment;

        public PayPalAdapter(PayPalPayment payPalPayment)
        {
            _payPalPayment = payPalPayment;
        }

        public string ProcessPayment(double amount)
        {
            return _payPalPayment.MakePaymentWithPayPal(amount);
        }
    }
}
