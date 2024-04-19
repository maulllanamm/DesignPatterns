using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Template
{
    public class ConcreteHouse : HouseTemplate
    {
        protected override string BuildFoundation()
        {
            return "Building foundation with cement, iron rods and sand";
        }
        protected override string BuildPillars()
        {
            return "Building Concrete Pillars with Cement and Sand";
        }
        protected override string BuildWalls()
        {
            return "Building Concrete Walls";
        }
        protected override string BuildWindows()
        {
            return "Building Concrete Windows";
        }
    }
}
