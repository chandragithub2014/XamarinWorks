using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinPractice.ProfileMVVM.View
{
    
    public class InvertBooleanConverter : IValueConverter
    {
        

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool original = (bool)value;
            return !original;
        }

       

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool original = (bool)value;
            return !original;
        }
    }
}
