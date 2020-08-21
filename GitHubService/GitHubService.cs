using StrykerDG.StrykerServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StrykerDG.StrykerServices.GitHubService
{
    public class GitHubService : StrykerService
    {
        public GitHubService(
            IHttpClientFactory clientFactory, 
            string token,
            string userAgent
        ) : base(clientFactory) 
        {
            var tokenBytes = Encoding.UTF8.GetBytes(token);
            var encodedToken = Convert.ToBase64String(tokenBytes);

            Client.BaseAddress = new Uri("https://api.github.com");
            Client.DefaultRequestHeaders.Add("Authentication", encodedToken);
            Client.DefaultRequestHeaders.Add("User-Agent", userAgent);
        }
    }
}
