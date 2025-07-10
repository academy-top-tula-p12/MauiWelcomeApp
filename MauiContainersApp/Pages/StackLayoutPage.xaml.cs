namespace MauiContainersApp.Pages;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();

		Label label4 = new Label()
		{
			Text = "Item 4",
			FontSize = 26.0,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			TextColor = Colors.DeepPink,
		};

		stackLayout.Children.Add(label4);

        Label label5 = new Label()
        {
            Text = "Item 5",
            FontSize = 26.0,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            TextColor = Colors.DeepPink,
        };

        stackLayout.Spacing = 50;
        stackLayout.Children.Add(label5);
    }
}