using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiListViewApp
{
    public class AirlineCell : ViewCell
    {
        Image logo;
        Label title, city, plains;

        public AirlineCell()
        {
            logo = new Image() { HeightRequest = 120 };
            title = new Label() { FontSize = 30 };
            city = new Label() { FontSize = 26, Margin = new Thickness(0, 0, 0, 20) };
            plains = new Label() { FontSize = 20 };

            HorizontalStackLayout itemLayout = new HorizontalStackLayout()
            {
                Padding = new Thickness(20)
            };

            VerticalStackLayout textLayout = new VerticalStackLayout();

            textLayout.Children.Add(title);
            textLayout.Children.Add(city);
            textLayout.Children.Add(plains);

            itemLayout.Children.Add(logo);
            itemLayout.Children.Add(textLayout);

            this.View = itemLayout;
        }

        public static BindableProperty ImageSourceProperty =
            BindableProperty.Create("ImageSource", typeof(ImageSource), typeof(AirlineCell), null);

        public static BindableProperty TitleProperty =
            BindableProperty.Create("Title", typeof(String), typeof(AirlineCell), "");

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public string Title
        {
            get => (String)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if(BindingContext is not null)
            {
                logo.Source = ImageSource;
                title.Text = Title;
            }
        }
    }
}
