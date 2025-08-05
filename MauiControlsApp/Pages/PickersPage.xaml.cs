using System.Globalization;

namespace MauiControlsApp.Pages;

public partial class PickersPage : ContentPage
{
	public PickersPage()
	{
		InitializeComponent();

        CultureInfo.CurrentCulture = new CultureInfo("de-DE");

        DatePicker datePicker = new DatePicker()
        {
            Format = "D",
            MaximumDate = DateTime.Now.AddDays(10),
            MinimumDate = DateTime.Now.AddDays(-10)
        };
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        labelDatePicker.Text = "Select Date: " + e.NewDate.ToString("dd.MM.yyyy");
    }

    
}