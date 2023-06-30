using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RicksFriends.Application;
using RicksFriends.Domain;

namespace RicksFriends.Infrastructure
{
    public class RickAndMortyApiClient : IRickAndMortyApiClient
    {
        private readonly HttpClient _httpClient;

        public RickAndMortyApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CharacterResponse> GetCharactersAsync(string status, string species, int minEpisodeCount, int page)
        {
            var url = $"https://rickandmortyapi.com/api/character/?status={status}&species={species}&page={page}";
            //url = $"https://rickandmortyapi.com/api/character/?page={page}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CharacterResponse>(content);

            result.Results = result.Results.Where(c => c.Episodes.Count() > minEpisodeCount).ToList();


            result.Info.Next = GetPageNumber(result.Info.Next);
            result.Info.Prev = GetPageNumber(result.Info.Prev);
            result.Info.Page = page;
            return result;
        }

        private static string GetPageNumber(string url)
        {
            var page = string.Empty;
            if (!string.IsNullOrEmpty(url))
            {
                Match match = Regex.Match(url, @"\bpage=(?<pageNumber>\d+)\b");
                if (match.Success)
                {
                    page = match.Groups["pageNumber"].Value;
                }                
            }
            return page;
        }
    }

}
