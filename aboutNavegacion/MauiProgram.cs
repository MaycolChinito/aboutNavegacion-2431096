using Microsoft.Extensions.Logging;

namespace aboutNavegacion;

//<Summary>
//<Createddate>16/7/2023</createddate>
//<company>INDEL</company>
//<lastmodificationdate>16/7/2023</lastmodificationdate>
//<lastmodificationdescription>
// unifiqué todos los programas anteriores, es decir, creé un menú principal y navegación entre paginas,
// que permita acceder a cada uno de los programas elaborados desde una sola aplicación
//</lastmodificationdescription>
//<lastmodifierautor> Maycol Barrera </lastmodifierautor>
//</Summary>

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

		return builder.Build();
	}
}
