﻿using DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility;
using DesignPatternsServices.BehavioralPatterns.State;
using DesignPatternsServices.BehavioralPatterns.State.Context;
using DesignPatternsServices.BehavioralPatterns.Strategy.Context;
using DesignPatternsServices.BehavioralPatterns.Strategy;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using DesignPatternsServices.BehavioralPatterns.Command.Invoker;
using DesignPatternsServices.BehavioralPatterns.Command;
using DesignPatternsServices.BehavioralPatterns.Command.Receiver;

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

    }
}
