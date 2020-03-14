using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPractice.ProfileMVVM.Model;

namespace XamarinPractice.ProfileMVVM.ViewModel
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        public Action DisplayProfileInvalidPrompt;
        public Action DisplayProfileSaveSuccessPrompt;
        public Action isCancelled;
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand saveCommand { protected set; get; }
        public ICommand cancelCommand { protected set; get; }
        public ProfileViewModel()
        {
            saveCommand = new Command(OnSubmit);
            cancelCommand = new Command(OnCancel);
        }
        public void OnCancel()
        {
            OnPropertyChanged(LastName = "");
            OnPropertyChanged(FirstName = "");
            OnPropertyChanged(ContactNumber = "");
            OnPropertyChanged(DOB = "");
           

            isCancelled();
           
        }
        public async void OnSubmit()
        {
            var profile = new Profile();
            profile.FirstName = firstName;
            profile.LastName = lastName;
            
            profile.ContactNumber = contactNumber;
            if (isIndian)
            {
                profile.Nationality = "Indian";

            }
            else
            {
                profile.Nationality = "Others";
            }
            if (isMale)
            {
                profile.Gender = "Male";

            }
            else
            {
                profile.Gender = "FeMale";
            }
           string day = someDate.Day.ToString("00");

           string month = someDate.Month.ToString("00");

           string year = someDate.Year.ToString();

            profile.DOB = day.ToString()+"-"+month.ToString()+"-"+year.ToString();
            Console.WriteLine("ProfileInfo::"+ profile.Nationality+profile.Gender);
            int id = await App.Database.SaveProfile(profile);
            if (id != -1)
            {
                //await DisplayAlert("Status", "Data Saved", "Ok");
                // await Navigation.PushAsync(new UserInfoListViewPage());
                DisplayProfileSaveSuccessPrompt();

              }
            else
            {
                DisplayProfileInvalidPrompt();
            }
            OnPropertyChanged(LastName = "");
            OnPropertyChanged(FirstName = "");
            OnPropertyChanged(ContactNumber = "");
            OnPropertyChanged(DOB = "");

        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {

                firstName = value;
                OnPropertyChanged();
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {

                lastName = value;
                OnPropertyChanged();
            }
        }

        private string dob;
        public string DOB
        { 
            get { return dob; }
            set
            {
                dob = value;
                OnPropertyChanged();
            }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged();
            }
        }

        private string contactNumber;
        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
                OnPropertyChanged();
            }
        }


        private bool isIndian;
        public  bool IsIndian
        {
            get { return isIndian; }
            set
            {
                isIndian = value;
                OnPropertyChanged();
            }
        }

        private bool isOthers;
        public bool IsOthers
        {
            get { return isOthers; }
            set
            {
                isOthers = value;
                OnPropertyChanged();
            }
        }


        private bool isMale;
        public bool IsMale
        {
            get { return isMale; }
            set
            {
                isMale = value;
                OnPropertyChanged();
               
               
                
            }
        }


        private bool isFeMale;
        public bool IsFeMale
        {
            get { return isFeMale; }
            set
            {
                isFeMale = value;
                OnPropertyChanged();
                


            }
        }

        private DateTime someDate;
        public DateTime SomeDate
        {
            get { return someDate; }
            set
            {
                someDate = value;
            }
        }

    }
}
