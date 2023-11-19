using CommunityToolkit.Maui.Views;
using CustomControls.MAUI.MessageBox.AppPresentations.CommonSource;

namespace MauiMessageBox;

public partial class SampleCustomMessageBox : Popup
{
	public SampleCustomMessageBox()
	{
		InitializeComponent();
        BindingContext = MauiServiceHandler.Current.GetServices<SampleCustomMessageBoxViewModel>().FirstOrDefault();
    }
}