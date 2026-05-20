using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Cinzel-Black.ttf", "CinzelBlack");
                    fonts.AddFont("Cinzel-Bold.ttf", "CinzelBold");
                    fonts.AddFont("Cinzel-Regular.ttf", "CinzelRegular");
                    fonts.AddFont("Cinzel-SemiBold.ttf", "CinzelSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
