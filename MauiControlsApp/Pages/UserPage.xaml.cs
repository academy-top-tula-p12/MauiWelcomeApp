namespace MauiControlsApp.Pages;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();

        buttonBackToMain.Clicked += async (sender, e) =>
        {
            await Navigation.PopAsync();
        };

        entryUserName.TextChanged += (sender, e) =>
        {
            labelUserAge.Text = "User Name: " + entryUserName.Text;
        };
    }
}