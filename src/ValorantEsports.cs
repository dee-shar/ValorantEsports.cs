using System.Net.Http;

namespace ValorantEsportsApi
{
    public class ValorantEsports
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://vlr.orlandomm.net/api/v1";
        public ValorantEsports()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetTeams()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/teams");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetTeam(int teamId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/teams/{teamId}");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetPlayers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/players");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlayer(int playerId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/players/{playerId}");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetEvents()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/events");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMatches()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/matches");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetResults()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/results");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
