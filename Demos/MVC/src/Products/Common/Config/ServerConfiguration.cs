using GroupDocs.Annotation.MVC.Products.Common.Util.Parser;
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace GroupDocs.Annotation.MVC.Products.Common.Config
{
    /// <summary>
    /// Server configuration
    /// </summary>
    public class ServerConfiguration : ConfigurationSection
    {
        private readonly NameValueCollection serverConfiguration = (NameValueCollection)ConfigurationManager.GetSection("serverConfiguration");

        public int HttpPort { get; set; } = 8080;
        public string HostAddress { get; set; } = "localhost";

        /// <summary>
        /// Get server configuration section of the web.config
        /// </summary>
        public ServerConfiguration()
        {
            YamlParser parser = new YamlParser();
            dynamic configuration = parser.GetConfiguration("server");
            ConfigurationValuesGetter valuesGetter = new ConfigurationValuesGetter(configuration);
            int defaultPort = Convert.ToInt32(serverConfiguration["httpPort"]);
            HttpPort = valuesGetter.GetIntegerPropertyValue("connector", defaultPort, "port");
            HostAddress = valuesGetter.GetStringPropertyValue("hostAddress", HostAddress);
        }
    }
}