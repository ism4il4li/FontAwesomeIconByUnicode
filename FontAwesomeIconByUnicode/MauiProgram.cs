namespace FontAwesomeIconByUnicode;

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
                //3.  Add Awesome Fonts
                //fonts.AddFont("Filename.Filetype", "Aliasname");
				//then go to FaByUnicode.xaml
                fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FAB");
                fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FAR");
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FAS");
            });

		return builder.Build();
	}
}
