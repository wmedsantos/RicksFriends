using System;
using Newtonsoft.Json;

namespace RicksFriends.Domain
{
    public class Info
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("next")]
        public string? Next { get; set; }

        [JsonProperty("prev")]
        public string? Prev { get; set; }

        public int? Page { get; set; }
        public Info(int count, int pages, string? next, string? prev, int page)
        {
            this.Count = count;
            this.Pages = pages;
            this.Next = next;
            this.Prev = prev;
            this.Page = page;
        }
    }
}

