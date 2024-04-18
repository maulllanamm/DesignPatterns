using DesignPatternServices_.CreationalPatterns.FactoryMethod.Client;
using DesignPatternServices_.CreationalPatterns.FactoryMethod.Concrete_Creator;
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
        
    }
}
