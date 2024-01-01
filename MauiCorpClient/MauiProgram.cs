﻿using MauiCorpClient.Data;
using MauiCorpClient.Services;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace MauiCorpClient
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.Services.AddSingleton(sp => new HttpClient { });
            builder.Services.AddSingleton<NavigationService>();
            builder.Services.AddSingleton<TopBarSharedStateService>();
            builder.Services.AddSingleton<ProgressBarService>();
            builder.Services.AddSingleton<AppStateService>();
            builder.Services.AddMudServices();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}