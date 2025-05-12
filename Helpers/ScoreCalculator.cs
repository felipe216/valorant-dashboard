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
            double kdaScore = (player.Kills + 0.5 + player.Assists) / (player.Deaths == 0 ? 1 : player.Deaths);
            double headshotScore = player.Headshots / ((player.Bodyshots + player.Headshots + player.Legshots) == 0 ? 1 : (double)(player.Bodyshots + player.Headshots + player.Legshots));
            double damageScore = player.DamageMade + player.DamageReceived;
            double utilityScore = player.C_Cast + player.Q_Cast + player.E_Cast + player.X_Cast;
            double behaviourScore = player.AfkRounds + player.FriendlyFireIn + player.FriendlyFireOut;
            double fbFdScore = player.FirstKills - player.FirstDeaths;

            return kdaScore * 2 + headshotScore * 1.5 + damageScore * 0.01 + utilityScore * 0.5 - behaviourScore * 1.5 + fbFdScore * 2;
        }
    }
}
