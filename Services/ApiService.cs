using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ValorantStatsAPP.Models;
using Newtonsoft.Json;
using System.Xml.Linq;
using ValorantStatsAPP.Helpers;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ValorantStatsAPP.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService() 
        {
            var config = ConfigManager.LoadConfig();
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.Token);
        }

        public async Task<List<MatchData>> GetMatchStatsAsync(string username,  string tag)
        {
            var url = $"https://api.henrikdev.xyz/valorant/v3/matches/br/{username}/{tag}";
            var response = await _client.GetAsync(url);
            System.Diagnostics.Debug.WriteLine(response);
            var json = await response.Content.ReadAsStringAsync();


            var apiResponse = JsonConvert.DeserializeObject<ApiResponse<MatchData>>(json);
            
            return apiResponse?.Data ?? new List<MatchData>();
        }
    }
}
