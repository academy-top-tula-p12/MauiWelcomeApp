using MauiControlsApp.Pages;

namespace MauiControlsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button()
            {
                WidthRequest = 200,
                Margin = new Thickness(20),
                Padding = new Thickness(20, 40),
                BorderWidth = 10,
                BorderColor = Colors.White,
                BackgroundColor = Color.FromRgb(120, 200, 67)
            };
            button.HeightRequest = 100;

            buttonBaseControls.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BaseControlsPage());
            };

            buttonUserPage.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new UserPage());
            };

            buttonBoxPage.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BoxScrollPage());
            };

        }

        
    }

}
