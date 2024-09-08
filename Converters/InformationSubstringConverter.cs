using System;
using System.Globalization;

namespace test_maui_app.Converters;

public class InformationSubstringConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string strValue && strValue.Trim().Length>10)
        {
            return $"{strValue.Trim().Substring(0, 10)}...";
        }
        return value as string;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
