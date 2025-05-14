using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantStatsAPP.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace ValorantStatsAPP.Models
{
    public class Player
    {

        public string? Puuid { get; set; }
        public string? Name { get; set; }
        public string? Tag { get; set; }
        public string? TeamId { get; set; }
        public string? Platform { get; set; }
        public string? PartyId { get; set; }

        public Agent? Agent { get; set; }
        public Stats? Stats { get; set; }
        public AbilityCasts? AbilityCasts { get; set; }
        public Tier? Tier { get; set; }

        public string? CardId { get; set; }
        public string? TitleId { get; set; }
        public string? PreferedLevelBorder { get; set; }
        public int AccountLevel { get; set; }
        public int SessionPlaytimeInMs { get; set; }

        public Behaviour? Behaviour { get; set; }
        public Economy? Economy { get; set; }

        public double Score => ScoreCalculator.Calculate(this);
    }
    public class Agent
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }

    public class Stats
    {
        public int Score { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int Headshots { get; set; }
        public int Legshots { get; set; }
        public int Bodyshots { get; set; }
        public Damage? Damage { get; set; }
    }

    public class Damage
    {
        public int Dealt { get; set; }
        public int Received { get; set; }
    }

    public class AbilityCasts
    {
        public int Grenade { get; set; }
        public int Ability_1 { get; set; }
        public int Ability_2 { get; set; }
        public int Ultimate { get; set; }
    }

    public class Tier
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Behaviour
    {
        public int AfkRounds { get; set; }
        public FriendlyFire? FriendlyFire { get; set; }
        public int RoundsInSpawn { get; set; }
    }

    public class FriendlyFire
    {
        public int Incoming { get; set; }
        public int Outgoing { get; set; }
    }

    public class Economy
    {
        public Spent? Spent { get; set; }
        public LoadoutValue? LoadoutValue { get; set; }
    }

    public class Spent
    {
        public double Overall { get; set; }
        public double Average { get; set; }
    }

    public class LoadoutValue
    {
        public double Overall { get; set; }
        public double Average { get; set; }
    }
}
