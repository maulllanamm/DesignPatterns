using DesignPatternServices_.CreationalPatterns.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.FactoryMethod.Creator
{
    public abstract class DocumentConverterFactory
    {
        public abstract IDocumentConverter CreateConverter();
    }
}
