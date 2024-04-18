using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternServices_.StructuralPatterns.Adapter.Adaptee;

namespace DesignPatternServices_.StructuralPatterns.Adapter.Adapter
{
    public class MobileBankingAdapter : IPaymentGateway
    {
        private readonly MobileBankingPayment _mobileBankingPayment;

        public MobileBankingAdapter(MobileBankingPayment mobileBankingPayment)
        {
            _mobileBankingPayment = mobileBankingPayment;
        }

        public string ProcessPayment(double amount)
        {
            return _mobileBankingPayment.MakePaymentWithMobileBanking(amount);
        }
    }
}
