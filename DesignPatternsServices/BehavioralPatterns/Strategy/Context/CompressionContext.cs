using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Strategy.Context
{
    public class CompressionContext
    {
        private ICompression _compression;
        public CompressionContext(ICompression compression)
        {
            _compression = compression;
        }

        public void SetStrategy(ICompression Compression)
        {
            _compression = Compression;
        }

        public string CreateArchive(string compressedArchiveFileName)
        {
            //The CompressFolder method is going to be invoked based on the strategy object
            return _compression.CompressFolder(compressedArchiveFileName);
        }
    }
}
