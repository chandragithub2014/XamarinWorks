using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Platform.Android;


namespace XamarinPractice.Droid
{
    [Activity(Label = "XamarinPractice", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
         // Window.SetSoftInputMode(SoftInput.AdjustResize);
           /* if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                // Bug in Android 5+, this is an adequate workaround
                AndroidBug5497WorkaroundForXamarinAndroid.assistActivity(this,WindowManager);
            }*/
           // AndroidBug5497WorkaroundForXamarinAndroid.assistActivity(this);
            //  Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
            //  Window.SetSoftInputMode(Android.Views.SoftInput.AdjustResize);
            /* if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
             {
                 Window.DecorView.SystemUiVisibility = 0;
                 var statusBarHeightInfo = typeof(FormsAppCompatActivity).GetField("_statusBarHeight", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                 statusBarHeightInfo.SetValue(this, 0);
                 Window.SetStatusBarColor(new Android.Graphics.Color(0, 0, 0, 255)); // Change color as required.
             }*/
            /*  App.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().
    UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);*/
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}