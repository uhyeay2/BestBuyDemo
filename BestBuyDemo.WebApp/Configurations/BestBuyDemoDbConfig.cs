using BestBuyDemo.Domain.Interfaces;

namespace BestBuyDemo.WebApp.Configurations
{
    public class BestBuyDemoDbConfig : IConfig
    {
        private static IConfigurationRoot Root => new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public string GetConfig() => Root["ConnectionStrings:BestBuyDemoDb"];
    }
}
