using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Template
{
    public class WoodenHouse : HouseTemplate
    {
        protected override string BuildFoundation()
        {
            return "Building foundation with cement, iron rods, wood and sand";
        }
        protected override string BuildPillars()
        {
            return "Building wood Pillars with wood coating";
        }
        protected override string BuildWalls()
        {
            return "Building Wood Walls";
        }
        protected override string BuildWindows()
        {
            return "Building Wood Windows";
        }
    }
}
