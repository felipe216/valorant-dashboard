using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using ValorantStatsAPP.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace ValorantStatsAPP.Helpers
{
    public class ConfigManager
    {
        public static ApiConfig Load()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            var settings = new ApiConfig();
            settings.BaseUrl = config["ApiConfig:BaseUrl"];
            settings.Token = config["ApiConfig:Token"];
            return settings;
        }
    }
}
