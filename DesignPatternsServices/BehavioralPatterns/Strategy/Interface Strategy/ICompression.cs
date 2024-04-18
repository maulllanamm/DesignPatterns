using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Strategy
{
    public interface ICompression
    {
        string CompressFolder(string compressArchiveFileName);
    }
}
