namespace MauiCollectionViewApp
{
    public partial class MainPage : ContentPage
    {
        public List<string> Cities { get; set; } = new()
        {
            "Moscow", "Irkutsk", "Kazan", "Vladivostok", "Tula"
        };

        public List<Airline> Airlines { get; set; } = new()
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

            collectionViewCities.ItemsSource = Cities;
            //collectionViewCities.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
            //{
            //    ItemSpacing = 10
            //};
            collectionViewCities.SelectionMode = SelectionMode.Multiple;

            BindingContext = this;
        }

        
    }
}
