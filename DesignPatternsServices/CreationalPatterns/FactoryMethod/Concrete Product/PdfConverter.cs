using DesignPatternServices_.CreationalPatterns.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.FactoryMethod
{
    public class PdfConverter : IDocumentConverter
    {
        public string Convert(string inputFile, string outputFile)
        {
            return $"Converting {inputFile} to PDF and saving as {outputFile}.";
        }
    }
}
