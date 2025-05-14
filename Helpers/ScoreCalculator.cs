using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantStatsAPP.Models;

namespace ValorantStatsAPP.Helpers
{
    public static class ScoreCalculator
    {
        public static double Calculate(Player player)
        {
            double kdaScore = (player.Stats.Kills + 0.5 + player.Stats.Assists) / (player.Stats.Deaths == 0 ? 1 : player.Stats.Deaths);

            int totalShots = player.Stats.Headshots + player.Stats.Bodyshots + player.Stats.Legshots;
            double headshotScore = totalShots == 0 ? 0 : (double)player.Stats.Headshots / totalShots;

            double damageScore = player.Stats.Damage.Dealt + player.Stats.Damage.Received;

            double utilityScore = player.AbilityCasts.Grenade +
                                  player.AbilityCasts.Ability_1 +
                                  player.AbilityCasts.Ability_2 +
                                  player.AbilityCasts.Ultimate;

            double behaviourScore = player.Behaviour.AfkRounds +
                                    player.Behaviour.FriendlyFire.Incoming +
                                    player.Behaviour.FriendlyFire.Outgoing;

            // Se você tiver esses campos na nova modelagem:
            //double fbFdScore = player.Stats.FirstKills - player.Stats.FirstDeaths; // <-- só se existirem no JSON/modelo


            return kdaScore * 2 + headshotScore * 1.5 + damageScore * 0.01 + utilityScore * 0.5 - behaviourScore * 1.5; //+ fbFdScore * 2;
        }
    }
}
