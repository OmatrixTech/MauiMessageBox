using CustomControls.MAUI.MessageBox.AppPresentations.CommonSource;

namespace MauiMessageBox;

public partial class MainPage : ContentPage
{
	

    MainPageViewModel mainPageViewModel = null;
    public MainPage()
    {
        InitializeComponent();
        mainPageViewModel = MauiServiceHandler.Current.GetServices<MainPageViewModel>().FirstOrDefault();
        this.BindingContext = mainPageViewModel;
    }


}

