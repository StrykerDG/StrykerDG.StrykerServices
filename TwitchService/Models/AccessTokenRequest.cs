using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.TwitchService.Models
{
    public class AccessTokenRequest
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("scope")]
        public string[] Scopes { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
