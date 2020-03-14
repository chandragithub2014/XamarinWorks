using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinPractice.ProfileMVVM.ViewModel;

namespace XamarinPractice.ProfileMVVM.View
{
    public partial class ProfilePage : ContentPage
    {
        
        public ProfilePage()
        {
            var vm = new ProfileViewModel();
            this.BindingContext = vm;
            vm.DisplayProfileSaveSuccessPrompt += () => DisplayAlert("Success", "Profile Saved  !!!!", "OK");
            vm.DisplayProfileInvalidPrompt += () => DisplayAlert("Error", "Profile Save Failed  ???", "OK");
            vm.isCancelled += () => DisplayAlert("Status", "Profile Save Cancelled", "OK");
            
            InitializeComponent();
        }
    }
}
//https://stackoverflow.com/questions/37901989/xamarin-forms-how-to-make-button-appear-at-the-bottom-of-a-page