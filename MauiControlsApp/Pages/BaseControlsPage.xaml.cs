namespace MauiControlsApp.Pages;

public partial class BaseControlsPage : ContentPage
{
	public BaseControlsPage()
	{
		InitializeComponent();

		Label labelClick = new Label()
		{
			Text = "Clicked 0",
			FontSize = 30,
			HorizontalOptions = LayoutOptions.Center,
		};

		int count = 0;
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		tapGestureRecognizer.Tapped += (sender, e) =>
		{
			count++;
			labelClick.Text = "Clicked " + count;
		};

		labelClick.GestureRecognizers.Add(tapGestureRecognizer);

		buttonBackToMain.Clicked += async (sender, e) =>
		{
			await Navigation.PopAsync();
		};

		stack.Children.Add(labelClick);

		PointerGestureRecognizer pointerGestureRecognizer = new PointerGestureRecognizer();
        pointerGestureRecognizer.PointerEntered += PointerGestureRecognizer_PointerEntered;
        pointerGestureRecognizer.PointerExited += PointerGestureRecognizer_PointerExited;
		buttonBackToMain.GestureRecognizers.Add(pointerGestureRecognizer);
	}

    private void PointerGestureRecognizer_PointerExited(object? sender, PointerEventArgs e)
    {
        buttonBackToMain.BackgroundColor = Colors.Aquamarine;
    }

    private void PointerGestureRecognizer_PointerEntered(object? sender, PointerEventArgs e)
    {
        buttonBackToMain.BackgroundColor = Colors.Coral;
    }
}