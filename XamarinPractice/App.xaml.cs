using System;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPractice.database;
using XamarinPractice.TemplateScreens;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
namespace XamarinPractice
{
    public partial class App : Xamarin.Forms.Application
    {
        static UserInfoDataBase userInfoDataBase = null;
        public App()
        {
            InitializeComponent();
            Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
            MainPage = new NavigationPage(new TemplateListScreenPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public static UserInfoDataBase Database
        {
            get
            {
                if (userInfoDataBase == null)
                {
                    userInfoDataBase = new UserInfoDataBase(Constants.DatabasePath);
                }
                return userInfoDataBase;
            }
        }
    }
}
