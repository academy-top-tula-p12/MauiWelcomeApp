namespace MauiResourceApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            //Label labelAll = new Label()
            //{
            //    Text = "Hello All",
            //    //TextColor = (Color)Resources["textRed"]
            //};
            //labelAll.SetDynamicResource(Label.TextColorProperty, "textRed");
            //stackVertical.Children.Add(labelAll);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            //DisplayAlert("Color", ((Color)this.Resources["textRed"]).ToString(), "Ok");
            this.Resources["textRed"] = Colors.Blue;
            //DisplayAlert("Color", ((Color)this.Resources["textRed"]).ToString(), "Ok");
        }
    }
}
