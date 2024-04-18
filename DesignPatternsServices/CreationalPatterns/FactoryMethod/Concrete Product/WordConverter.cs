using DesignPatternServices_.CreationalPatterns.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.FactoryMethod
{
    public class WordConverter : IDocumentConverter
    {
        public string Convert(string inputFile, string outputFile)
        {
            return $"Converting {inputFile} to Word and saving as {outputFile}.";
        }
    }
}
