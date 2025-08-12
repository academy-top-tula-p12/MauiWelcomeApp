namespace MauiListViewApp
{
    public partial class MainPage : ContentPage
    {
        public List<string> Cities { set; get; } = new List<string>()
        {
            "Moscow", "St Petersburg", "Novosibirsk"
        };

        public List<Airline> Airlines { set; get; } = new List<Airline>()
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
            //listViewCities.ItemsSource = cities;
            BindingContext = this;

            listViewAirlines.ItemsSource = Airlines;
        }

        private void listViewCities_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //labelSelectedCity.Text = $"Selected City: {e.SelectedItem.ToString()}";
        }
    }
}
