using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RicksFriends.Domain
{
    public class Character
    {
        [JsonProperty("id")]
        public int Id { get; private set;    }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("origin")]
        public object Origin { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("episode")]
        public IEnumerable<string> Episodes { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        public Character() { }

        public Character(
            int id,
            string name,
            string status,
            string species,
            string type,
            string gender,
            object origin,
            object location,
            string image,
            IEnumerable<string> episode,
            string url,
            string created
           )
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Species = species;
            this.Type = type;
            this.Gender = gender;
            this.Origin = origin;
            this.Location = location;
            this.Image = image;
            this.Episodes = episode;
            this.Url = url;
            this.Created = created;
        }
    }
}
