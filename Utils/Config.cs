using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TIAutomation.Utils
{
    public static class Config
    {
        private static readonly IConfiguration Configuration;

        static Config()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public static string Get(string name)
        {
            string appSettings = Configuration[name];
            return appSettings;
        }

        public static IConfigurationSection GetSection(string name)
        {
            return Configuration.GetSection(name);
        }
    }
}
