using DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BehavioralPatterns  :ControllerBase
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
    }
}
