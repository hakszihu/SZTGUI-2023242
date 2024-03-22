using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace worksop_03
{
    internal class EtelToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case "Appetizer":
                    return "Red";
                case "Drink":
                    return "Blue";
                case "MainCourse":
                    return "Magenta";
                case "Dessert":
                    return "Green";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //bool ->string
            switch ((string)value)
            {
                case "Red":
                    return "Appetizer";
                case "Blue":
                    return "Drink";
                case "Magenta":
                    return "MainCourse";
                case "Green":
                    return "Dessert";
                default:
                    return null;
            }
        }

    }
    }
