using Microsoft.Extensions.Configuration;

namespace SPOS.Classes
{
    public class Configurations
    {
        public static IConfigurationSection configurationSection;

        public static string GetConfiguration(string property)
        {
            if (configurationSection is null)
            {
                configurationSection = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings");
            }

            return configurationSection[property];
        }
    }
}
