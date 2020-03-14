using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinPractice.ListMVVM.Model;

namespace XamarinPractice.ListMVVM.ViewModel
{
    public class MyHTTP
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<Car>> action)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/jly7p");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<Car>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
}
