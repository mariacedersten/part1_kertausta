using Microsoft.Extensions.Configuration;
using Serilog;

namespace BC_ohjelmointi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Käytä Microsoftin nugetteja
            // ja lue konfiguraatio tedosto (appsettings.json)
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            // Käytä Serilog nugettia konfeguroidaksesi
            // Serilogin käyttämän appsettings.json-tiedostosta
            // luettua konfeguraatiota
            var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

            // Esimerkki
            logger.Error("Paha error");
            logger.Warning("Varoitus!");
            logger.Information("Hello, world!");

        }


    }

}