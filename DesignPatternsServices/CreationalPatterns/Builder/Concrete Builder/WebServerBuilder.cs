using DesignPatternServices_.CreationalPatterns.BuilderPattern.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.BuilderPattern.Concrete_Builder
{
    public class WebServerBuilder : ServerBuilder
    {
        public override void SetOperatingSystem()
        {
            Configuration.OperatingSystem = "Linux";
        }
        public override void SetServerType()
        {
            Configuration.ServerType = "Web";
        }
        public override void InstallDatabase()
        {
            // For this web server, no DB installation
        }
        public override void InstallMiddleware()
        {
            Configuration.Middleware = new List<string>();
            Configuration.Middleware.Add("Nginx");
            Configuration.Middleware.Add("Node.js");
        }
        public override void EnableFirewall()
        {
            Configuration.HasFirewall = true;
        }
    }
}
