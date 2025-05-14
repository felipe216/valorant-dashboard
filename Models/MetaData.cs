using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ValorantStatsAPP.Models
{
    public class MetaData
    {
        public required JObject Map { get; set; }
        public int GameLengthInMs { get; set; }
        public int StartedAt { get; set; }
        public int RoundsPlayed { get; set; }
        public required String MatchId { get; set; }
        public required String ModeId { get; set; }
    }
}
