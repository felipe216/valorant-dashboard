using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ValorantStatsAPP.Models
{
    public class MetaData
    {
        public required String Map {  get; set; }
        public int GameLength { get; set; }
        public int GameStart { get; set; }
        public int RoundsPlayed { get; set; }
        public required String MatchId { get; set; }
        public required String ModeId { get; set; }
    }
}
