using DesignPatternServices_.StructuralPatterns.Adapter;
using DesignPatternServices_.StructuralPatterns.Adapter.Adaptee;
using DesignPatternServices_.StructuralPatterns.Adapter.Adapter;
using DesignPatternServices_.StructuralPatterns.Bridge.Abstraction;
using DesignPatternServices_.StructuralPatterns.Bridge.ConcreteAbstraction;
using DesignPatternServices_.StructuralPatterns.Bridge.ConcreteImplementor;
using DesignPatternServices_.StructuralPatterns.Composite;
using DesignPatternServices_.StructuralPatterns.Decorator;
using DesignPatternServices_.StructuralPatterns.Facade;
using DesignPatternServices_.StructuralPatterns.Flyweight;
using DesignPatternServices_.StructuralPatterns.Proxy;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using IComponent = DesignPatternServices_.StructuralPatterns.Composite.IComponent;

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

        [HttpGet]
        public ActionResult Composite()
        {
            //Creating Leaf Objects or you can say child objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            //Creating Composite Objects
            Composite motherBoard = new Composite("MotherBoard");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            //Adding Mother Board and Hard Disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            //Adding Mouse and Keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            //Adding Cabinet and Peripherals in Computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            return Ok(computer.DisplayPrice());
        }

        [HttpGet]
        public ActionResult Flyweight()
        {
            var shop = new CoffeeShop();

            shop.TakeOrder("Cappuccino", 1);
            shop.TakeOrder("Espresso", 2, "With extra sugar");
            shop.TakeOrder("Cappuccino", 3);
            shop.TakeOrder("Latte", 4);

            return Ok(shop.ServeOrders());
        }

        [HttpGet]
        public ActionResult Proxy()
        {
            // Menggunakan Proxy untuk mengakses objek RealSubject
            Proxy proxy = new Proxy();

            // Pertama kali permintaan diproses, objek RealSubject dibuat
            proxy.Request();

            // Permintaan berikutnya menggunakan objek RealSubject yang sudah ada
            return Ok(proxy.Request());
        }
    }
}
