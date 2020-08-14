﻿using Newtonsoft.Json;
using StrykerDG.StrykerServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StrykerDG.StrykerServices
{
    public abstract class StrykerService : IStrykerService
    {
        public HttpClient Client { get; set; }

        public StrykerService(IHttpClientFactory clientFactory, string token)
        {
            Client = clientFactory.CreateClient();
            Client.BaseAddress = new Uri("https://api.github.com");

            var tokenBytes = Encoding.UTF8.GetBytes(token);
            var encodedToken = Convert.ToBase64String(tokenBytes);

            Client.DefaultRequestHeaders.Add("Authentication", encodedToken);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<StrykerServiceResponse> Delete(string endpoint, object payload)
        {
            throw new NotImplementedException();
        }

        public Task<StrykerServiceResponse> Get(string endpoint)
        {
            var response = Client.GetAsync(endpoint).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(StrykerServiceResponse.Success(content));
            }
            else
                return Task.FromResult(StrykerServiceResponse.Failure(response.Content));
        }

        public async Task<StrykerServiceResponse> Patch(string endpoint, object payload)
        {
            throw new NotImplementedException();
        }

        public async Task<StrykerServiceResponse> Post(string endpoint, object payload)
        {
            throw new NotImplementedException();
        }
    }
}