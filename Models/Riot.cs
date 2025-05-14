using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ValorantStatsAPP.Models
{
    public class Riot
    {
        public String? Name { get; set; }

        public String? Tag { get; set; }

        public String? Puuid { get; set; }
    }
}
