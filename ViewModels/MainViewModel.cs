using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using ValorantStatsAPP.Models;
using ValorantStatsAPP.Services;

namespace ValorantStatsAPP.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private readonly ApiService _apiService = new();
        private ObservableCollection<MatchData> _matches = new();

        public ObservableCollection<MatchData> Matches
        {
            get { return _matches; }
            set { _matches = value; OnPropertyChanged(nameof(Matches)); }
        }
        public ObservableCollection<Player>? PlayersList { get; set; }

        public async Task LoadMatchesAsync(string name, string tag)
        {
            var result = await _apiService.GetMatchStatsAsync(name, tag);
            Matches = new ObservableCollection<MatchData>(result);
            
            OnPropertyChanged(nameof(Matches));

            Dictionary<string, Player> playersDict = new();

            foreach (MatchData match in Matches)
            {
                foreach (var player in match.Players)
                {
                    if (player.Name != name && player.Tag != tag)
                    {
                        continue;
                    }
                    string? puuid = player.Puuid;
                    if (string.IsNullOrWhiteSpace(puuid))
                    {
                        continue;
                    }
                    if (playersDict.ContainsKey(puuid))
                    {
                        var existingPlayer = playersDict[puuid];

                        existingPlayer.Stats.Kills += player.Stats.Kills;
                        existingPlayer.Stats.Deaths += player.Stats.Deaths;
                        existingPlayer.Stats.Assists += player.Stats.Assists;

                        existingPlayer.Stats.Headshots += player.Stats.Headshots;
                        existingPlayer.Stats.Bodyshots += player.Stats.Bodyshots;
                        existingPlayer.Stats.Legshots += player.Stats.Legshots;

                        existingPlayer.Stats.Damage.Dealt += player.Stats.Damage.Dealt;
                        existingPlayer.Stats.Damage.Received += player.Stats.Damage.Received;

                        if (existingPlayer.AbilityCasts != null && player.AbilityCasts != null)
                        {
                            existingPlayer.AbilityCasts.Grenade += player.AbilityCasts.Grenade;
                            existingPlayer.AbilityCasts.Ability_1 += player.AbilityCasts.Ability_1;
                            existingPlayer.AbilityCasts.Ability_2 += player.AbilityCasts.Ability_2;
                            existingPlayer.AbilityCasts.Ultimate += player.AbilityCasts.Ultimate;
                        }

                        if (existingPlayer.Behaviour != null && player.Behaviour != null)
                        {
                            existingPlayer.Behaviour.AfkRounds += player.Behaviour.AfkRounds;

                            if (existingPlayer.Behaviour.FriendlyFire != null && player.Behaviour.FriendlyFire != null)
                            {
                                existingPlayer.Behaviour.FriendlyFire.Incoming += player.Behaviour.FriendlyFire.Incoming;
                                existingPlayer.Behaviour.FriendlyFire.Outgoing += player.Behaviour.FriendlyFire.Outgoing;
                            }
                        }

                    }
                    else
                    {
                        playersDict.Add(puuid, player);
                    }
                    PlayersList = new ObservableCollection<Player>(playersDict.Values);

                    OnPropertyChanged(nameof(PlayersList));
                }
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
