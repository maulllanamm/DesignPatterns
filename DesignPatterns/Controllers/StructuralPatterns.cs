using DesignPatternServices_.StructuralPatterns.Adapter;
using DesignPatternServices_.StructuralPatterns.Adapter.Adaptee;
using DesignPatternServices_.StructuralPatterns.Adapter.Adapter;
using DesignPatternServices_.StructuralPatterns.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StructuralPatterns : ControllerBase
    {


        [HttpGet]
        public ActionResult Adapter()
        {
            PayPalPayment payPalPayment = new PayPalPayment();
            IPaymentGateway paymentGateway = new PayPalAdapter(payPalPayment);

            return Ok(paymentGateway.ProcessPayment(200));
        }

        [HttpGet]
        public ActionResult Facade()
        {
            Order order = new Order();
            return Ok(order.PlaceOrder());
        }
    }
}
