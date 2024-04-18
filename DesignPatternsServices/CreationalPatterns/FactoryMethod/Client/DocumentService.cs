using DesignPatternServices_.CreationalPatterns.FactoryMethod.Creator;
using DesignPatternServices_.CreationalPatterns.FactoryMethod.Interface;

namespace DesignPatternServices_.CreationalPatterns.FactoryMethod.Client
{
    public class DocumentService
    {
        public string ExportDocument(DocumentConverterFactory factory, string inputFile, string outputFile)
        {
            IDocumentConverter converter = factory.CreateConverter();
            return converter.Convert(inputFile, outputFile);
        }
    }
}
