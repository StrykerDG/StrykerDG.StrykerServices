using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.ClockifyService.Models
{
    public class Tag
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }
}
