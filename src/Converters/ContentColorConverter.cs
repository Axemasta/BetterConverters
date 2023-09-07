using BetterConverters.Enums;
using BetterConverters.Models;
using System.Globalization;

namespace BetterConverters.Converters;

#nullable enable
public class ContentColorConverter : ConverterBase<Content?, Color>
{
    protected override Color? Convert(Content? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is null)
        {
            return null;
        }

        switch (value.Type)
        {
            case MediaType.Photo:
                {
                    return Colors.Magenta;
                }

            case MediaType.Video:
                {
                    return Colors.Green;
                }

            case MediaType.Article:
                {
                    return Colors.Blue;
                }

            default:
                {
                    return Colors.Yellow;
                }
        }
    }

    protected override Content ConvertBack(Color value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
#nullable disable