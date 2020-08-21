using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.TwitchService.Models
{
    public class FollowsToData
    {
        [JsonProperty("from_id")]
        public string FromId { get; set; }
        [JsonProperty("from_name")]
        public string FromName { get; set; }
        [JsonProperty("to_id")]
        public string ToId { get; set; }
        [JsonProperty("to_name")]
        public string ToName { get; set; }
        [JsonProperty("followed_at")]
        public DateTimeOffset FollowedAt { get; set; }
    }
}
