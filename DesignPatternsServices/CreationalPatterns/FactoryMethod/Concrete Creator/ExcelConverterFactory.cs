using DesignPatternServices_.CreationalPatterns.FactoryMethod.Creator;
using DesignPatternServices_.CreationalPatterns.FactoryMethod.Interface;

namespace DesignPatternServices_.CreationalPatterns.FactoryMethod.Concrete_Creator
{
    public class ExcelConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new ExcelConverter();
        }
    }
}
