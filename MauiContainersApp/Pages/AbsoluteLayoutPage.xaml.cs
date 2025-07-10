namespace MauiContainersApp.Pages;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();

		BoxView boxView = new BoxView()
		{
			Color = Colors.Chocolate,
		};
        absoluteLayout.Add(boxView);
		absoluteLayout.SetLayoutBounds(
			boxView,
			new Rect(400, 150, 250, 200));

		Label labelHello = new Label()
		{
			FontSize = 30.0,
			TextColor = Colors.White,
			Text = "Hello People!"
		};
		absoluteLayout.Add(labelHello);
		absoluteLayout.SetLayoutBounds(
			labelHello,
			new Rect(410, 160, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

        BoxView boxView2 = new BoxView()
        {
            Color = Colors.Yellow,
        };
        absoluteLayout.Add(boxView2);
		absoluteLayout.SetLayoutFlags(boxView2, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.All);
        absoluteLayout.SetLayoutBounds(
            boxView2,
            new Rect(0.2, 0.2, 0.2, 0.2));
    }
}