using DesignPatternServices_.CreationalPatterns.BuilderPattern.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.BuilderPattern.Director
{
    public class ServerDeployment
    {
        public void Deploy(ServerBuilder builder)
        {
            builder.SetOperatingSystem();
            builder.SetServerType();
            builder.InstallDatabase();
            builder.InstallMiddleware();
            builder.EnableFirewall();
        }
    }
}
