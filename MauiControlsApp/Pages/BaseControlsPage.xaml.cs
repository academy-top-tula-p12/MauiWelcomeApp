namespace MauiControlsApp.Pages;

public partial class BaseControlsPage : ContentPage
{
	public BaseControlsPage()
	{
		InitializeComponent();

		buttonBackToMain.Clicked += async (sender, e) =>
		{
			await Navigation.PopAsync();
		};
	}
}