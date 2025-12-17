using GenPass.UI.Services;
using GenPass.UI.Services.Interfaces;
using GenPass.UI.ViewModels;
using Microsoft.Extensions;
using Microsoft.Extensions.Http;

namespace GenPass.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services.AddHttpClient<ICredencialService, CredencialService>();
            builder.Services.AddTransient<CredencialViewModel>();



            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            return builder.Build();
        }
    }
}
