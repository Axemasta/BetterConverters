using BetterConverters.Pages;
using BetterConverters.ViewModels;
using Microsoft.Extensions.Logging;

namespace BetterConverters
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<ConverterPage>();
            builder.Services.AddTransient<ConverterViewModel>();

            return builder.Build();
        }
    }
}