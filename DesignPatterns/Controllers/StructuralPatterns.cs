using DesignPatternServices_.StructuralPatterns.Adapter;
using DesignPatternServices_.StructuralPatterns.Adapter.Adaptee;
using DesignPatternServices_.StructuralPatterns.Adapter.Adapter;
using DesignPatternServices_.StructuralPatterns.Bridge.Abstraction;
using DesignPatternServices_.StructuralPatterns.Bridge.ConcreteAbstraction;
using DesignPatternServices_.StructuralPatterns.Bridge.ConcreteImplementor;
using DesignPatternServices_.StructuralPatterns.Decorator;
using DesignPatternServices_.StructuralPatterns.Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Text;

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

        [HttpGet]
        public ActionResult Decorator()
        {
            var stringBuilder = new StringBuilder();
            PlainPizza plainPizzaObj = new PlainPizza();
            string plainPizza = plainPizzaObj.MakePizza();

            stringBuilder.AppendLine($"{plainPizza}");

            ChickenPizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
            string chickenPizza = chickenPizzaDecorator.MakePizza();

            stringBuilder.AppendLine($"{chickenPizza}");

            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
            string vegetables = vegPizzaDecorator.MakePizza();

            stringBuilder.AppendLine($"{vegetables}");

            return Ok(stringBuilder.ToString());
        }

        [HttpGet]
        public ActionResult Bridge()
        {
            AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
            return Ok(longMessage.SendMessage("Hallo, this is brige pattern"));
        }
    }
}
