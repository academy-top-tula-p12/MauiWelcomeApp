
namespace MauiControlsApp
{
    public partial class App : Application
    {
        const int newHeight = 500;
        const int newWidth = 600;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}
