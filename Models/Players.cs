using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ValorantStatsAPP.Models
{
    public class Players
    {
        [JsonProperty("all_players")]
        public required List<JObject> AllPlayers { get; set; }
    }
}
