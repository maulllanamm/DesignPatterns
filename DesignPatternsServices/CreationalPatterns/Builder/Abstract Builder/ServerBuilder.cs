using DesignPatternServices_.CreationalPatterns.BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.BuilderPattern.Abstract_Builder
{
    public abstract class ServerBuilder
    {
        protected ServerConfiguration Configuration { get; private set; } = new ServerConfiguration();

        public abstract void SetOperatingSystem();
        public abstract void SetServerType();
        public abstract void InstallDatabase();
        public abstract void InstallMiddleware();
        public abstract void EnableFirewall();

        public ServerConfiguration GetConfiguration() => Configuration;
    }
}
