using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;
using XamarinPractice.model;

namespace XamarinPractice.network
{
    public partial class MyNetworkListPage : ContentPage
    {
        public IList<PostUsers> PostLists { get; private set; }
        //PostUsers postUsers = new PostUsers();
        bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public MyNetworkListPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            isBusy = true;
            try
            {
                PostLists = await fetchPostsAsync();

                BindingContext = this;
            }catch (Exception ex)
            {
               
            }
            finally
            {
               IsBusy = false;
            }
          

        }


        private async Task<List<PostUsers>> fetchPostsAsync()
        {
            var _restClient = RestService.For<RetroInterface>("https://jsonplaceholder.typicode.com");
            return await _restClient.GetUserInfo();

        }
    }
}
