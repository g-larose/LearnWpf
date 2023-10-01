﻿using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace LearnWpf.Domain.Converters;

public class BoolToColorBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value == true)
            return new SolidColorBrush(Colors.Green);
        return new SolidColorBrush(Colors.LightGray);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
