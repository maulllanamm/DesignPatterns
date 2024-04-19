using DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility;
using DesignPatternsServices.BehavioralPatterns.State;
using DesignPatternsServices.BehavioralPatterns.State.Context;
using DesignPatternsServices.BehavioralPatterns.Strategy.Context;
using DesignPatternsServices.BehavioralPatterns.Strategy;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using DesignPatternsServices.BehavioralPatterns.Command.Invoker;
using DesignPatternsServices.BehavioralPatterns.Command;
using DesignPatternsServices.BehavioralPatterns.Command.Receiver;
using DesignPatternsServices.BehavioralPatterns.Visitor;
using DesignPatternsServices.BehavioralPatterns.Template;
using System;
using DesignPatternsServices.BehavioralPatterns.Memento;
using DesignPatternsServices.BehavioralPatterns.Mediator;
using DesignPatternsServices.BehavioralPatterns.Iterator;

namespace DesignPatterns.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BehavioralPatterns : ControllerBase
    {
        [HttpGet]
        public ActionResult ChainOfResponsibility()
        {
            // Setup validation chain
            var nonEmptyValidator = new NotEmptyValidator();
            var emailValidator = new EmailFormatValidator();
            var passwordValidator = new PasswordStrengthValidator();
            nonEmptyValidator.SetNext(emailValidator);
            emailValidator.SetNext(passwordValidator);

            // Sample input
            var userInput = new User
            {
                Email = "tester@gmail.com",
                Password = "StrongPass123"
            };
            if (nonEmptyValidator.Validate(userInput))
            {
                return Ok("Registration Successful!");
            }
            else
            {
                return Ok("Validation Failed!");
            }
        }

        [HttpGet]
        public ActionResult State()
        {
            Order order = new Order();
            var res = new StringBuilder();
            res.AppendLine(order.PrintStatus());  // Output: Order is in NEW state.
            res.AppendLine(order.NextState());
            res.AppendLine(order.PrintStatus());  // Output: Order is PROCESSED.
            res.AppendLine(order.NextState());
            res.AppendLine(order.PrintStatus());  // Output: Order is SHIPPED.
            res.AppendLine(order.PrevState());
            res.AppendLine(order.PrintStatus());  // Output: Order is PROCESSED.
            res.AppendLine(order.SetState(new Canceled()));
            res.AppendLine(order.PrintStatus());  // Output: Order is CANCELED.
            return Ok(res.ToString());
        }

        [HttpGet]
        public ActionResult Strategy()
        {
            var res = new StringBuilder();
            ICompression strategy = new ZipCompression();
            //Pass ZipCompression Strategy as an argument to the CompressionContext constructor
            CompressionContext ctx = new CompressionContext(strategy);
            res.AppendLine(ctx.CreateArchive("StrategyPattern"));
            //Changing the Strategy using SetStrategy Method
            ctx.SetStrategy(new RarCompression());
            res.AppendLine(ctx.CreateArchive("StrategyPattern"));
            return Ok(res.ToString());
        }

        [HttpGet]
        public ActionResult Command()
        {
            Chef chef = new Chef();
            IOrderCommand pastaOrder = new PastaOrderCommand(chef);
            IOrderCommand burgerOrder = new BurgerOrderCommand(chef);

            Waiter waiter = new Waiter();

            waiter.TakeOrder(pastaOrder);
            waiter.TakeOrder(burgerOrder);
            // Later, the waiter sends all orders to the kitchen
            return Ok(waiter.PlaceOrders());
        }

        [HttpGet]
        public ActionResult Visitor()
        {
            var res = new StringBuilder();

            IProduct book = new Book { Price = 100, ISBN = "123456", Title = "Design Patterns" };
            IProduct laptop = new Electronic { Price = 1000, Brand = "Dell", Model = "XPS 15" };
            IProduct apple = new Grocery { Price = 2, Name = "Apple", ExpiryDate = DateTime.Now.AddDays(10) };

            var discountVisitor = new DiscountVisitor();
            var descriptionVisitor = new DescriptionVisitor();

            book.Accept(discountVisitor);
            res.AppendLine($"Discounted Price of Book: ${discountVisitor.DiscountedPrice}");
            res.AppendLine(book.Accept(descriptionVisitor));

            laptop.Accept(discountVisitor);
            res.AppendLine($"Discounted Price of Laptop: ${discountVisitor.DiscountedPrice}");
            res.AppendLine(laptop.Accept(descriptionVisitor));

            apple.Accept(discountVisitor);
            res.AppendLine($"Discounted Price of Apple: ${discountVisitor.DiscountedPrice}");
            res.AppendLine(apple.Accept(descriptionVisitor));

            return Ok(res.ToString());
        }


        [HttpGet]
        public ActionResult Template()
        {
            var res = new StringBuilder();

            res.AppendLine("Build a Concrete House");
            HouseTemplate houseTemplate = new ConcreteHouse();
            //Call the Template Method to Build the Concrete House
            res.AppendLine(houseTemplate.BuildHouse());


            res.AppendLine("Build a Wooden House");
            houseTemplate = new WoodenHouse();
            //Call the Template Method to Build the Wooden House
            res.AppendLine(houseTemplate.BuildHouse());
            return Ok(res.ToString());
        }
        [HttpGet]
        public ActionResult Memento()
        {
            var res = new StringBuilder();
            BankAccount account = new BankAccount(1000.00M);
            TransactionHistory history = new TransactionHistory();

            res.AppendLine(account.Deposit(200));
            history.SaveState(account);  // Balance: 1200
            res.AppendLine(account.Withdraw(100));
            history.SaveState(account);  // Balance: 1100
            res.AppendLine(account.Withdraw(50));
            history.SaveState(account);  // Balance: 1050
            // Oops! That last withdrawal was a mistake. Let's undo it.
            res.AppendLine(account.RestoreFromMemento(history.UndoTransaction()));

            return Ok(res.ToString());
        }
        [HttpGet]
        public ActionResult Mediator()
        {
            var res = new StringBuilder();
            var chatroom = new ChatRoom();
            var john = new Participant("John");
            var jane = new Participant("Jane");
            chatroom.Register(john);
            chatroom.Register(jane);
            res.AppendLine(john.Send("Jane", "Hey there!"));
            res.AppendLine(jane.Send("John", "Hi John!"));
            return Ok(res.ToString());

        }
        [HttpGet]
        public ActionResult Iterator()
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Anurag", 100));
            collection.AddEmployee(new Employee("Pranaya", 101));
            collection.AddEmployee(new Employee("Santosh", 102));
            collection.AddEmployee(new Employee("Priyanka", 103));
            collection.AddEmployee(new Employee("Abinash", 104));
            collection.AddEmployee(new Employee("Preety", 105));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            var res = new StringBuilder();

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                res.AppendLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            return Ok(res.ToString());

        }

    }
}
