using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RicksFriends.Domain
{
    public class CharacterResponse
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<Character> Results { get; set; }

        public CharacterResponse(Info info, List<Character> results)
        {
            this.Info = info;
            this.Results = results;
        }
    }
}
