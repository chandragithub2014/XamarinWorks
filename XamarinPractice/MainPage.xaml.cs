using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPractice.database;
using XamarinPractice.network;
using XamarinPractice.TemplateScreens;

namespace XamarinPractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           

        }

        private async void  signUp_Clicked(System.Object sender, System.EventArgs e)
        {
             await Navigation.PushAsync(new RegistrationPage());

        }

        private async void login_Clicked(System.Object sender, System.EventArgs e)
        {
            // await Navigation.PushAsync(new RegistrationPage());

          /* bool isLoginValid = App.Database.LoginValidate(uname.Text, pwd.Text);
            if (isLoginValid)
            {
               await Navigation.PushAsync(new UserInfoListViewPage());
            }
            else
            {
                await DisplayAlert("Login", "Enter Valid Credentials", "OK");
            }
 */
            var user = App.Database.Validatelogin(uname.Text, pwd.Text);
            if (user != null)
            {
                //await DisplayAlert("Login", "Result" + user.UserName + ":::" + user.Password, "OK");
                await DisplayAlert("Login", "Login Success", "OK");
                // await Navigation.PushAsync(new TemplateListScreenPage());
            }
            else
            {
                await DisplayAlert("Login", "Enter Valid Credentials or Register", "OK");
            }
            
            //validateLogin

        }
    }
}
