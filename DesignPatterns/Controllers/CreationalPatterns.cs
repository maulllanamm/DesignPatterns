using DesignPatternServices_.CreationalPatterns.AbstractFactory.Client;
using DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Factory;
using DesignPatternServices_.CreationalPatterns.BuilderPattern.Concrete_Builder;
using DesignPatternServices_.CreationalPatterns.BuilderPattern.Director;
using DesignPatternServices_.CreationalPatterns.FactoryMethod.Client;
using DesignPatternServices_.CreationalPatterns.FactoryMethod.Concrete_Creator;
using DesignPatternServices_.CreationalPatterns.Prototype.Concrete_Prototype;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CreationalPatterns : ControllerBase
    {


        [HttpGet]
        public ActionResult FactoryMethod()
        {
            var documentService = new DocumentService();

            // jika ingin export ke pdf
            var pdf = documentService.ExportDocument(new PdfConverterFactory(), "file1.docx", "file1.pdf");

            // jika ingin export ke Excel
            var excel = documentService.ExportDocument(new ExcelConverterFactory(), "file1.docx", "file1.csv");

            // jika ingin export ke word
            var word = documentService.ExportDocument(new WordConverterFactory(), "file1.pdf", "file1.docx");

            return Ok(pdf);
        }

        [HttpGet]
        public ActionResult AbstractFactory()
        {
            var postgreSQLFactory = new PostgreSQLFactory();
            var postgreSQLManager = new DatabaseManager(postgreSQLFactory.CreateCommand(), postgreSQLFactory.CreateConnection());
            var res = postgreSQLManager.PerformDatabaseOperations("Select * From Users");
            return Ok(res);
        }

        [HttpGet]
        public ActionResult Builder()
        {
            var deployer = new ServerDeployment();
            var webServerBuilder = new WebServerBuilder();

            deployer.Deploy(webServerBuilder);

            var serverConfig = webServerBuilder.GetConfiguration();
            var res = serverConfig.DisplayConfig();
            return Ok(res);
        }

        [HttpGet]
        public ActionResult Prototype()
        {
            EmployeeProfile existingEmployee = new EmployeeProfile
            {
                Name = "Maulana Muhammad",
                Address = "Lawanggintung",
                Role = "Software Developer",
                Salary = 100_000_000,
            };

            var old = existingEmployee.DisplayProfile();
            // HR wants to create a profile for a new temporary staff member with a similar role and salary
            EmployeeProfile tempEmployee = (EmployeeProfile)existingEmployee.Clone();

            tempEmployee.Name = "Clone Maulana Muhammad";
            tempEmployee.Address = "Batutulis";
            var newProfile = tempEmployee.DisplayProfile();


            return Ok($@"{old}
{newProfile}");
        }
    }
}
