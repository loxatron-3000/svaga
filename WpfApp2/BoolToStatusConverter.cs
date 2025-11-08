using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp2
{
    public class BoolToStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter as string == "color")
            {
                return (bool)value ? new SolidColorBrush(Color.FromArgb(255, 220, 255, 220)) : new SolidColorBrush(Color.FromArgb(255, 255, 220, 220));
            }

            return (bool)value ? "Active" : "Inactive";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}