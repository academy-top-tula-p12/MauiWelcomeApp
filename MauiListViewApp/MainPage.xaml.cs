using System.Collections.ObjectModel;

namespace MauiListViewApp
{
    public partial class MainPage : ContentPage
    {
        public List<string> Cities { set; get; } = new List<string>()
        {
            "Moscow", "St Petersburg", "Novosibirsk"
        };

        public ObservableCollection<AirlineGrouping<String, Airline>> AirlinesGroups { set; get; }
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
            //listViewCities.ItemsSource = cities;
            

            var airlinesGroups = Airlines.GroupBy(a => a.City)
                                         .Select(ag => new AirlineGrouping<string, Airline>(ag.Key, ag));

            AirlinesGroups = new(airlinesGroups);
            //listViewAirlines.ItemsSource = AirlinesGroups;
            //listViewAirlines.ItemsSource = Airlines;

            BindingContext = this;
        }

        private void listViewCities_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //labelSelectedCity.Text = $"Selected City: {e.SelectedItem.ToString()}";
        }

        private void buttonAddAirline_Clicked(object sender, EventArgs e)
        {
            Airlines.Add(new Airline()
            {
                Title = "S7",
                City = "Irkutsk",
                Logo = "logo_s7_01.png",
                Plains = 550,
            });
        }
    }
}
