using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;
using XamarinPractice.ListMVVM.Model;

namespace XamarinPractice.ListMVVM.ViewModel
{
    public class CarsViewModel : INotifyPropertyChanged
    {


        public Action DisplayAlertInView;

        public IList<Car> CarLists{ get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string Name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        private  Car selectedItem { get; set; }
        public Car SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem()
        {
            DisplayAlertInView();
        }
        private ObservableCollection<Car> items;
        public ObservableCollection<Car> Items
        {
            get { return items; }
            set
            {

                items = value;
                OnPropertyChanged();
            }
        }

        private bool isBusy = false;
        public bool IsBusy
        {

            get { return isBusy; }
            set {
                if (isBusy == value)
                    return;
                isBusy = value;
                OnPropertyChanged();
            }
        }
        public  CarsViewModel()
        {

            // IsEnabled = true;

            LoadData();
            fetchDataFromHTTP();



       }

        private  void  LoadData()
        {
               
                    
                Items = new ObservableCollection<Car>(){

            new Car()
            {
                CarID = 501,
                Make = "Audy",
                YearOfModel =  2015
            },
            new Car()
            {
                CarID = 502,
                Make = "Maruti",
                YearOfModel =  2005
            },
            new Car()
            {
                CarID = 503,
                Make = "Hyundai",
                YearOfModel =  2000
            }

        };
        }
        private async Task<List<Car>> fetchPostsAsync()
        {
            var _restClient = RestService.For<RetroInterface>("https://api.myjson.com/bins");
            return await _restClient.GetCarDetails();

        }


        private async void fetchDataFromHTTP()
        {
            if (IsBusy)
                return;
            try {
                

                IsBusy = true;
                await MyHTTP.GetAllNewsAsync(list =>
            {
                foreach (Car item in list)
                {
                    Items.Add(item);

                }
                IsBusy = false;
            });
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
