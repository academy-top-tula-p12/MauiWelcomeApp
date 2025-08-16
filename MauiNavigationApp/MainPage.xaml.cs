using MauiNavigationApp.Pages;

namespace MauiNavigationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonToSecond_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SecondPage());
        }
    }
}
