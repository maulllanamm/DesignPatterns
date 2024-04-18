namespace DesignPatternServices_.CreationalPatterns.BuilderPattern.Product
{
    public class ServerConfiguration
    {
        public string OperatingSystem { get; set; }
        public string ServerType { get; set; } // web, Database, Cache
        public string Database { get; set; } // optional : database software
        public List<string> Middleware { get; set; } 
        public bool HasFirewall { get; set; } 

        public string DisplayConfig()
        {
            return $@"
Os : {OperatingSystem} 
Server Type : {ServerType}
Database : {Database ?? "None"}
Middleware : {string.Join(", ", Middleware)}
Firewall : {(HasFirewall ? "Enabled" : "Disabled")}";

        }
    }
}
