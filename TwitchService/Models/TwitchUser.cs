using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.TwitchService.Models
{
    public class TwitchUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("broadcaster_type")]
        public string BroadcasterType { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }
        [JsonProperty("view_count")]
        public int ViewCount { get; set; }
    }
}
