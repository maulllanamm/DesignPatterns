using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Adapter
{
    public interface IPaymentGateway
    {
        string ProcessPayment(double amount);
    }
}
