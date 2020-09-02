using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace StrykerDG.StrykerServices.ClockifyService.Models
{
    public class TimeEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("billable")]
        public bool Billable { get; set; }
        [JsonProperty("taskId")]
        public string TaskId { get; set; }
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
        [JsonProperty("timeInterval")]
        public TimeInterval TimeInterval { get; set; }
        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

    }

    public class TimeInterval
    {
        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }
        [JsonProperty("end")]
        public DateTimeOffset? End { get; set; }
        // Duration is format of PT1H30M15S,
        // or 1 hour, 30 minutes, 15 seconds
        [JsonProperty("duration")]
        public string Duration { get; set; }
    }
}
