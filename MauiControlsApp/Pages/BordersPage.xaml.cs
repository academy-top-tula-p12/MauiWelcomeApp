using Microsoft.Maui.Controls.Shapes;

namespace MauiControlsApp.Pages;

public partial class BordersPage : ContentPage
{
	public BordersPage()
	{
		InitializeComponent();

		imageLandscape.Source = ImageSource.FromFile("image01.jpg");
		

        Border border = new Border()
		{
			Stroke = Colors.DarkBlue,
			StrokeThickness = 5,
			Margin = new Thickness(20),
			Padding = new Thickness(20),
			BackgroundColor = Colors.Blue,
			StrokeShape = new RoundRectangle()
			{
				CornerRadius = 20
			},
			Content = new Label()
			{
				Text = "Hello world",
				FontSize = 30,
				TextColor = Colors.White,
			}
		};

		stackLayoutBorders.Add(border);
	}

    private void entryName_TextChanged(object sender, TextChangedEventArgs e)
    {
		labelName.Text = "Hello " + entryName.Text;
    }
}