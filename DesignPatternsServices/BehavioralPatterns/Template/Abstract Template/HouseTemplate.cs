using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Template
{
    public abstract class HouseTemplate
    {
        protected abstract string BuildFoundation();
        protected abstract string BuildPillars();
        protected abstract string BuildWalls();
        protected abstract string BuildWindows();

        public string BuildHouse()
        {
            var res = new StringBuilder();

            res.AppendLine(BuildFoundation());
            res.AppendLine(BuildPillars());
            res.AppendLine(BuildWalls());
            res.AppendLine(BuildWindows());

            return res.ToString();

        }
    }
}
