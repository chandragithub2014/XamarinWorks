using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPractice.model;

namespace XamarinPractice.ImageList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyImageListViewPage : ContentPage
    {
        public IList<Contacts> Items { get; set; }

        public MyImageListViewPage()
        {
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            initItems();
            BindingContext = this;
        }

        private void initItems()
        {
            Items = new List<Contacts>
            {
                new Contacts{
                    ContactDetails = "9885750539",
                    ContactName = "Chandra1",
                    ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRSyKVTjLq0GPFdi7h9if0qeTa4K1uDvA72FO6eoVLJJ__rNuXRtw"
                   //ImageUrl = "https://via.placeholder.com/80.png/09f/fff"
                },
                new Contacts
                {
                    ContactDetails = "9885750549",
                    ContactName = "Chandra",
                    ImageUrl = "https://via.placeholder.com/80"


                },
                new Contacts
                {
                    ContactDetails = "9885750529",
                    ContactName = "Chandra2",
                    ImageUrl = "https://via.placeholder.com/80.png/09f/0000FF"
                },
                new Contacts
                {
                    ContactDetails = "9885730549",
                    ContactName = "Chandra3",
                    ImageUrl = "https://via.placeholder.com/80.png/08f/00FFFF"


                }
            };
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
