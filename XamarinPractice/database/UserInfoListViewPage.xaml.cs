using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPractice.models;

namespace XamarinPractice.database
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserInfoListViewPage : ContentPage
    {
        public IList<User> Items { get; set; }

        public UserInfoListViewPage()
        {
            InitializeComponent();
           
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Items = new List<User>();
            Items = await App.Database.getUserInfoFromTable();
            BindingContext = this;
           // MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
