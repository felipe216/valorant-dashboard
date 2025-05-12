using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using ValorantStatsAPP.Models;

namespace ValorantStatsAPP.Helpers
{
    internal class ConfigManager
    {
        public static ApiConfig LoadConfig()
        {
            string json = File.ReadAllText("appsettings.json");
            return JsonSerializer.Deserialize<ApiConfig>(json);
        }
    }
}
