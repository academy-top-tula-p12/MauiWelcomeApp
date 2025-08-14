using System.Collections.ObjectModel;

namespace MauiCarouselApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Airline> Airlines { set; get; } = new()
        {
            new()
            {
                Title = "Aeroflot",
                City = "Moscow",
                Logo = "logo_aeroflot_01.png",
                Plains = 1560,
            },
            new()
            {
                Title = "Pobeda",
                City = "Moscow",
                Logo = "logo_pobeda_01.png",
                Plains = 560,
            },
            new()
            {
                Title = "Red Wings",
                City = "Moscow",
                Logo = "logo_redwings_01.png",
                Plains = 890,
            },
            new()
            {
                Title = "Smart Avia",
                City = "Arhangelsk",
                Logo = "logo_smartavia_01.png",
                Plains = 320,
            },
        };
        public MainPage()
        {
            InitializeComponent();
            carouselAirlines.ItemsSource = Airlines;
        }

        private void carouselAirlines_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {

        }
    }
}
