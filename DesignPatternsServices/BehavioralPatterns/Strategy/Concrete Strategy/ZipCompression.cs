
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Strategy
{
    public class ZipCompression : ICompression
    {
        public string CompressFolder(string compressArchiveFileName)
        {
            return $"Folder is compressed using Zip approach: {compressArchiveFileName}.zip file is created";
        }
    }
}
