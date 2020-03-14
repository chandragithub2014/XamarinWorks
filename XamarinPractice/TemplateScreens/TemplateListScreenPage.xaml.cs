using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPractice.database;
using XamarinPractice.ImageList;
using XamarinPractice.ListMVVM.View;
using XamarinPractice.model;
using XamarinPractice.network;
using XamarinPractice.ProfileMVVM.View;
using XamarinPractice.XamTabs;

namespace XamarinPractice.TemplateScreens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemplateListScreenPage : ContentPage
    {
        public IList<TemplateInfo> Items { get; set; }

        public TemplateListScreenPage()
        {
            InitializeComponent();

           
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            fetchTemplateInfoList();
            BindingContext = this;
        }
        private void fetchTemplateInfoList()
        {
            Items = new List<TemplateInfo>
            {
                 new TemplateInfo
                {
                    TemplateName = "Login Flow"

                },
                new TemplateInfo
                {
                    TemplateName = "DataBase List"

                },
                new TemplateInfo
                {
                    TemplateName = "Image List"
                },
                new TemplateInfo
                {
                    TemplateName = "Network List"
                },
                new TemplateInfo
                {
                    TemplateName = "Tabbed Pages"
                },
                new TemplateInfo
                {
                    TemplateName = "MVVM List"
                },
                new TemplateInfo
                {
                    TemplateName = "MVVM ProfileForm"
                }


            };

        }

            async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            if (e.Item != null)
            {
                

                var index = e.ItemIndex;
                var templateName = Items[index].TemplateName;
                if (templateName.Equals("DataBase List"))
                {
                    await Navigation.PushAsync(new UserInfoListViewPage());
                }else if (templateName.Equals("Network List"))
                {
                    await Navigation.PushAsync(new MyNetworkListPage());
                }
                else if (templateName.Equals("Tabbed Pages"))
                {
                    await Navigation.PushAsync(new PracticeTabbedPage());
                }
                else if (templateName.Equals("Image List"))
                {
                    await Navigation.PushAsync(new MyImageListViewPage());
                }
                else if (templateName.Equals("MVVM List"))
                {
                    await Navigation.PushAsync(new CarListPage());
                }
                else if (templateName.Equals("MVVM ProfileForm"))
                {
                    await Navigation.PushAsync(new ProfilePage());
                }else if(templateName.Equals("Login Flow"))
                {
                    await Navigation.PushAsync(new MainPage());

                }
                //  await DisplayAlert("Item Tapped", "An item was tapped."+templateName, "OK");
            }


            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
