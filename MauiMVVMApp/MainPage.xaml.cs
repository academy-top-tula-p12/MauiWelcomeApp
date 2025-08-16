using MauiMVVMApp.Models;

namespace MauiMVVMApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            //AirlineViewModel airlineViewModel = new AirlineViewModel()
            //{
            //    Title = "Aeroflot",
            //    City = "Moscow",
            //    PlainsCount = 169
            //};

            //BindingContext = airlineViewModel;

            AirlinesViewModel airlinesViewModel = new AirlinesViewModel();
            airlinesViewModel.Airlines.Add(
                new()
                {
                    Title = "Aeroflot",
                    City = "Moscow",
                    PlainsCount = 169
                });
            


            BindingContext = airlinesViewModel;
        }

        
    }
}
