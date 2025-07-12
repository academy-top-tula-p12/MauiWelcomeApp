namespace MauiControlsApp.Pages;

public partial class BoxScrollPage : ContentPage
{
	public BoxScrollPage()
	{
		InitializeComponent();
	}

    private void scrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
		labelScrollX.Text = "X: " + scrollView.ScrollX;
		labelScrollY.Text = "Y: " + scrollView.ScrollY;
    }
}