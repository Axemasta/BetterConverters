using BetterConverters.Enums;
using System.Globalization;

namespace BetterConverters.Converters;

public class MediaTypeColorConverter : ConverterBase<MediaType, Color>
{
    protected override Color Convert(MediaType value, Type targetType, object parameter, CultureInfo culture)
    {
        switch (value)
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

    protected override MediaType ConvertBack(Color value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
