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

        public async Task LoadMatchesAsync(string name, string tag)
        {
            var result = await _apiService.GetMatchStatsAsync(name, tag);
            Matches = new ObservableCollection<MatchData>(result);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
