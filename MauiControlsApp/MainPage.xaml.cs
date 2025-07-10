using MauiControlsApp.Pages;

namespace MauiControlsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            buttonBaseControls.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BaseControlsPage());
            };

        }

        
    }

}
