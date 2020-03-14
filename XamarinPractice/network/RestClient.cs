using System;
using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using XamarinPractice.models;
using XamarinPractice.model;

namespace XamarinPractice.network
{
    public class RestClient
    {
        private readonly RetroInterface _restClient;
        public RestClient()
        {

            _restClient = RestService.For<RetroInterface>("https://jsonplaceholder.typicode.com");
            
        }

        public async Task<List<PostUsers>> GetPosts()
        {
            return await _restClient.GetUserInfo();
        }
    }
}
