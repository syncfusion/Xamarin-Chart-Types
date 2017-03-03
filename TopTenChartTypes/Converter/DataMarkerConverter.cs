using System;
using Xamarin.Forms;

namespace Sample
{
    public class DatamarkerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (System.Convert.ToDouble(value) >= 35)
            {
                return "warm.png";
            }
            else if (System.Convert.ToDouble(value) < 35 && System.Convert.ToDouble(value) > 25)
            {
                return "Cloudy.png";
            }
            else
            {
                return "Rainy.png";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
