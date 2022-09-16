using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Boards.PcbManufacturing.Converters
{
    public class ErrorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Brushes.Black; // TODO: find out how not to touch the border in this case
            }

            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
