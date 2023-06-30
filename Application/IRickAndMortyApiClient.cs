using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RicksFriends.Domain;

namespace RicksFriends.Application
{
    public interface IRickAndMortyApiClient
    {
        Task<CharacterResponse> GetCharactersAsync(string status, string species, int minEpisodeCount, int page);
    }
}
