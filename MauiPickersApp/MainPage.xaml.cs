using System.Threading.Tasks;

namespace MauiPickersApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void TimePicker_TimeSelected(object sender, TimeChangedEventArgs e)
        {
            //labelTimePicker.Text = "Time select: " + e.NewTime.ToString();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Time")
                labelTimePicker.Text = "Time select: " + timePicker.Time.ToString();
        }

        private void stepperDept_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelStepper.Text = "Value: " + e.NewValue.ToString();
                //stepperDept.Value.ToString();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slider.Value = Math.Floor(slider.Value);
            labelSlider.Text = "Value: " + e.NewValue.ToString();
        }

        private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender is CheckBox check)
            {
                if (e.Value)
                    check.Color = Colors.GreenYellow;
                else
                    check.Color = Colors.Magenta;
            }
        }

        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            labelLanguage.Text = "Language: " + (sender as RadioButton)?.Content;
        }

        private async void buttonProgressStart_Clicked(object sender, EventArgs e)
        {
            progress.Progress = 0;
            activityIndicator.IsRunning = true;
            for (double i = 0; i <= 1; i+=0.1)
            {
                progress.Progress = i;
                await Task.Delay(1000);
            }
            activityIndicator.IsRunning = false;
        }
    }
}
