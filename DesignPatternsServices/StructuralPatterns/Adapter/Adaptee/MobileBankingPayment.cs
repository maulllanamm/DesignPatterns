using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Adapter.Adaptee
{
    public class MobileBankingPayment
    {
        public string MakePaymentWithMobileBanking(double amount)
        {
            return $"Processing mobile banking payment of ${amount}";
        }
    }
}
