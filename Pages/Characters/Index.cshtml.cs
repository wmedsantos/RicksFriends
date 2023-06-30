using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RicksFriends.Application;
using RicksFriends.Domain;
using RicksFriends.Pages.ViewModels;

namespace RicksFriends.Pages.Characters
{
	
    public class CharactersModel : PageModel
    {
        private readonly IRickAndMortyApiClient _apiClient;

        public CharacterViewModel CharacterData { get; set; }

        public CharactersModel(IRickAndMortyApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task OnGetAsync([FromQuery(Name = "activepage")] int? activepage)
        {
            int pageNumber = activepage ?? 1;            
            var characterResponse = await _apiClient.GetCharactersAsync("unknown", "alien", 1, pageNumber);
            var characters = characterResponse.Results;

            var paginationInfo = characterResponse.Info;

            CharacterData = new CharacterViewModel
            {
                Characters = characters,
                PaginationInfo = paginationInfo
            };
        }
    }
    
}
