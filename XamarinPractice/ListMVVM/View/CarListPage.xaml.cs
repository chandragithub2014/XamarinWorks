using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinPractice.ListMVVM.ViewModel;

namespace XamarinPractice.ListMVVM.View
{
    public partial class CarListPage : ContentPage
    {
        public CarListPage()
        {
            InitializeComponent();
            var vm = new CarsViewModel();
            BindingContext = vm;
           
        }

        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var details = e.Item as Model.Car;
            DisplayAlert("Success", "Car Info::" + details.Make+":::"+details.YearOfModel, "OK") ;
        }
        /*void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
        }*/
    }
}
