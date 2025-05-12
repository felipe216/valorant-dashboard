using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantStatsAPP.Helpers;

namespace ValorantStatsAPP.Models
{
    public class Player
    {
        public Riot? RiotData { get; set; }

        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int Headshots { get; set; }
        public int Bodyshots { get; set; }
        public int Legshots { get; set; }
        public int DamageMade { get; set; }
        public int DamageReceived { get; set; }
        public int C_Cast { get; set; }
        public int Q_Cast { get; set; }
        public int E_Cast { get; set; }
        public int X_Cast { get; set; }
        public int FirstKills { get; set; }
        public int FirstDeaths { get; set; }
        public int AfkRounds { get; set; }
        public int FriendlyFireIn { get; set; }
        public int FriendlyFireOut { get; set; }

        public double Score => ScoreCalculator.Calculate(this);
    }
}
