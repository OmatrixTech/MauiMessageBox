using CommunityToolkit.Maui;
using CustomControls.MAUI.MessageBox.AppPresentations.CommonSource;
using CustomControls.MAUI.MessageBox.AppPresentations.Utilities;
using CustomControls.MAUI.MessageBox;

namespace MauiMessageBox;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        try
        {
            //Initial setup for MAUI messagebox[Application Level declaration]
            ModalMessageBoxConfigurationSetup.SetupModalMessageBox(
              customMessageBoxTextColor: Color.FromArgb("#000000"),
              customMessageBoxHeightRequest: 450,
              customMessageBoxWidthRequest: 330,
              customMessageBoxBackgroundColor: Color.FromArgb("#FFFFFF"),
              customMessageBoxTitlePosition: LayoutOptions.StartAndExpand,
              customMessageBoxButtonBackgroundColor: Color.FromArgb("#000000"),
              CustomMessageBoxButtonTextColor: Color.FromArgb("#FFFFFF")
              );
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
            RegisterEssentials(builder.Services);
            RegisterPages(builder.Services);
            RegisterViewModels(builder.Services);
            builder.UseMauiCommunityToolkit();//Registering for MAUI Popup
            var app = builder.Build();
            MauiServiceHandler.MauiAppBuilder = app;
            return app;
        }
        catch (Exception ex)
        {

            return null;
        }
    }
    static void RegisterPages(in IServiceCollection services)
    {
        services.AddTransient<MainPage>();
    }
    static void RegisterViewModels(in IServiceCollection services)
    {
        services.AddTransient<MainPageViewModel>();
        services.AddTransient<SampleCustomMessageBoxViewModel>();
    }
    static void RegisterEssentials(in IServiceCollection services)
    {
        services.AddSingleton<IModalMessageBoxServiceHandler, ModalMessageBoxServiceHandler>();
    }
}
