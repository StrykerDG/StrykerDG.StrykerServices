using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.TwitchService.Models
{
    public class FollowsTo
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("data")]
        public List<FollowsToData> Data { get; set; }
    }
}
