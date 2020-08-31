using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace StrykerDG.StrykerServices.ClockifyService
{
    public class ClockifyService : StrykerService
    {
        public ClockifyService(
            IHttpClientFactory clientFactory,
            string apiKey
        ) : base(clientFactory)
        {
            Client.BaseAddress = new Uri("https://api.clockify.me/api/v1");
            Client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
        }
    }
}
