﻿using Microsoft.Extensions.Logging;

namespace MyMauiApp;

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

	    builder.Services.AddSingleton<LocalDbService>();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<RTLSamplePage>();
	
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
