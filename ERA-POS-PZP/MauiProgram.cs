using Blazored.LocalStorage;
using ERA_POS_PZP.Data;
using Radzen;

namespace ERA_POS_PZP;

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
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddSingleton<DataService>();
        builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<ContextMenuService>();
        builder.Services.AddScoped<TooltipService>();
        builder.Services.AddScoped<NotificationService>();
        builder.Services.AddBlazoredLocalStorage();

        return builder.Build();
    }
}
