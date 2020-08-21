using Newtonsoft.Json;
using StrykerDG.StrykerServices.TwitchService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace StrykerDG.StrykerServices.TwitchService
{
    public class TwitchService : StrykerService
    {
        public TwitchService(
            IHttpClientFactory clientFactory
        ) : base(clientFactory) 
        {
            // Set the base address so we can get an app token
            Client.BaseAddress = new Uri("https://id.twitch.tv");
        }

        public AccessTokenRequest GetAppAccessToken(
            string clientId, 
            string clientSecret, 
            List<string> scopes = null
        )
        {
            var endpoint = $"oauth2/token" +
                $"?client_id={clientId}" +
                $"&client_secret={clientSecret}" +
                $"&grant_type=client_credentials";
            
            if(scopes != null && scopes.Count > 0)
            {
                var scopeString = string.Join(" ", scopes.ToArray());
                endpoint += $"&scope={scopeString}";
            }

            var result = new AccessTokenRequest();
            var response = Client.PostAsync(endpoint, null).Result;
            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<AccessTokenRequest>(content);
            }

            return result;
        }

        public void SetHttpClientHeaders(string token, string clientId)
        {
            // Change the base address to the default api endpoint and set the app token
            Client.BaseAddress = new Uri("https://api.twitch.tv/helix");
            Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            Client.DefaultRequestHeaders.Add("Client-ID", clientId);
        }
    }
}
