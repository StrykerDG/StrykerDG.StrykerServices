using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.GitHubService.Models
{
    public class GitHubUser
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("public_repos")]
        public int PublicRepos { get; set; }
        [JsonProperty("public_gists")]
        public int PublicGists { get; set; }
        [JsonProperty("followers")]
        public int Followers { get; set; }
        [JsonProperty("following")]
        public int Following { get; set; }
    }
}
