using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ValorantStatsAPP.Models
{
    public class MatchData
    {
        public required MetaData MetaData { get; set; }
        public required List<Player> Players { get; set; }
        public required List<JObject> Teams { get; set; }
        public required List<JObject> Rounds { get; set; }
    }
}
