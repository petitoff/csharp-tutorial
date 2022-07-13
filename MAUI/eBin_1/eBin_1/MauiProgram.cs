using eBin_1.ViewModel;
using eBin_1.ViewModel.Services;
using eBin_1.Views;

namespace eBin_1;

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

		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<Configurator>();
        builder.Services.AddSingleton<ListOfExports>();

        builder.Services.AddSingleton<ConfiguratorViewModel>();
		builder.Services.AddSingleton<ConfiguratorService>();

        return builder.Build();
	}
}
