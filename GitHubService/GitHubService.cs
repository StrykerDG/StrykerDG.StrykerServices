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
        ) : base(clientFactory, token) 
        {
            Client.DefaultRequestHeaders.Add("User-Agent", userAgent);
        }
    }
}
