namespace MauiNavigationApp.Pages;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();

	}

    private async void ButtonBackToMain_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}