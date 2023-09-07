using BetterConverters.Enums;
using System.Globalization;

namespace BetterConverters.Converters;

public class MediaTypeImageConverter : ConverterBase<MediaType, ImageSource>
{
    protected override ImageSource Convert(MediaType value, Type targetType, object parameter, CultureInfo culture)
    {
        switch (value)
        {
            case MediaType.Photo:
                {
                    return ImageSource.FromUri(new Uri("https://images.emojiterra.com/google/noto-emoji/unicode-15/color/share/1f4f8.jpg"));
                }

            case MediaType.Video:
                {
                    return ImageSource.FromUri(new Uri("https://i.pinimg.com/1200x/68/3e/ce/683ecec56ca1f9bd0b2b552f24aac7f9.jpg"));
                }

            case MediaType.Article:
                {
                    return ImageSource.FromUri(new Uri("https://images.emojiterra.com/google/noto-emoji/unicode-15/color/512px/1f4f0.png"));
                }

            default:
                {
                    return ImageSource.FromUri(new Uri("https://cdn.vox-cdn.com/thumbor/98px1VwmYYivQd0nhjThlz8MYgo=/0x0:700x353/1200x628/filters:focal(350x177:351x178)/cdn1.vox-cdn.com/uploads/chorus_asset/file/7382831/ios-10-shrug-emoji.png"));
                }
        }
    }

    protected override MediaType ConvertBack(ImageSource value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
