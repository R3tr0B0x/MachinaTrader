using System.Collections.Generic;
using MachinaTrader.Globals.Structure.Models;

namespace MachinaTrader.Globals.Models
{
    public class MainConfig
    {
        public SystemOptions SystemOptions = new SystemOptions();
        public TradeOptions TradeOptions = new TradeOptions();
        public TelegramNotificationOptions TelegramOptions = new TelegramNotificationOptions();
        public List<ExchangeOptions> ExchangeOptions = new List<ExchangeOptions> { };
        public DisplayOptions DisplayOptions = new DisplayOptions();
    }

    public class SystemOptions
    {
        // Database stuff
        public string Database { get; set; } = "MongoDB";
        public string DatabaseUrl { get; set; } = "localhost";
        public int DatabasePort { get; set; } = 27017;
        public string DatabaseUsername { get; set; } = "";
        public string DatabasePassword { get; set; } = "";

        // Frontend stuff
        public int WebPort { get; set; } = 5000;
        public string RsaPrivateKey { get; set; } = "";
        public string DefaultUserName { get; set; } = "admin";
        public string DefaultUserEmail { get; set; } = "admin@localhost";
        public string DefaultUserPassword { get; set; } = "admin";
        public string Theme { get; set; } = "dark";
    }

}
