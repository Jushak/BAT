using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BAT_WPF.Views
{
    class SumConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double tot = 0;
            foreach (double value in values)
                tot += value;
            return tot.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return Array.ConvertAll<Type, Object>(targetTypes, t => value);
        }
    }
}
