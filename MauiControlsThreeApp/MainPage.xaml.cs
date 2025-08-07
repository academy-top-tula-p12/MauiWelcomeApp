namespace MauiControlsThreeApp
{
    public partial class MainPage : ContentPage
    {

        List<string> cities = new()
        {
            "Moscow",
            "Votoneg",
            "Kazan",
            "Orel"
        };
        public MainPage()
        {
            InitializeComponent();

            //pickerList.ItemsSource = cities;
        }

        //private void pickerList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    labelPickerCity.Text = "Selected City: " + pickerList.SelectedItem.ToString();
        //}

        //private void EntryCell_Completed(object sender, EventArgs e)
        //{

        //}

        //private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        //{

        //}
    }
}
