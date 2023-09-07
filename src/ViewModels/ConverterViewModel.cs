using BetterConverters.Enums;
using BetterConverters.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BetterConverters.ViewModels;

public partial class ConverterViewModel : ObservableObject
{
    [ObservableProperty]
    public MediaType mediaType = MediaType.Video;

    public List<MediaType> SupportedMediaTypes { get; }

    public List<Content> Content { get; }

    public ConverterViewModel()
    {
        SupportedMediaTypes = new List<MediaType>()
        {
            MediaType.Video,
            MediaType.Photo,
            MediaType.Article,
        };

        Content = new List<Content>()
        {
            new Content()
            {
                Id = 1,
                Name = "Youtube Video",
                Type = MediaType.Video,
            },
            new Content()
            {
                Id = 2,
                Name = "TikTok Meme",
                Type = MediaType.Video,
            },
            new Content()
            {
                Id = 3,
                Name = "I can has cheezeburger",
                Type = MediaType.Photo,
            }
        };
    }
}
