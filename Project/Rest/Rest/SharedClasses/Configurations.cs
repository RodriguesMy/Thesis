using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.SharedClasses
{
    public class Configurations
    {
        public static IConfigurationSection configurationSection;

        public static string GetConfiguration(string property)
        {
            if(configurationSection is null) {
                configurationSection = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSetings");
            }

            return configurationSection[property];
        }
    }
}
