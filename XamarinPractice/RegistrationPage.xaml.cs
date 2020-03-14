using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using XamarinPractice.database;
using XamarinPractice.models;

namespace XamarinPractice
{
    public partial class RegistrationPage : ContentPage
    {
       private User user = null;
        public RegistrationPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            user = new User();
        }
        private async void register_Clicked(System.Object sender, System.EventArgs e)
        {
            // await Navigation.PushAsync(new RegistrationPage());
            user.Name = name.Text;
            user.UserName = username.Text;
            user.Password = password.Text;
            user.Place = place.Text;
            
            
           int id =  await App.Database.SaveUser(user);
            if(id != -1)
            {
                //await DisplayAlert("Status", "Data Saved", "Ok");
                await Navigation.PushAsync(new UserInfoListViewPage());
            }
            else
            {
                await DisplayAlert("Status", "Data Save Failed !!!!", "Ok");
            }

        }
    }
}
