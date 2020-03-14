using System;
using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using XamarinPractice.ListMVVM.Model;

namespace XamarinPractice.ListMVVM.ViewModel
{
    public  class RestClient
    {
      //  private readonly RetroInterface _restClient;
      /*  public RestClient()
        {

            _restClient = RestService.For<RetroInterface>("https://api.myjson.com/bins");
            
        }*/

        public static async Task<List<Car>> GetPosts()
        {
         //   RetroInterface  _restClient = RestService.For<RetroInterface>("https://api.myjson.com/bins");
            return await RestService.For<RetroInterface>("https://api.myjson.com/bins").GetCarDetails();
        }
    }
}
