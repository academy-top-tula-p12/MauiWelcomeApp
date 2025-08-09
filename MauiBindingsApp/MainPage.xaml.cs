namespace MauiBindingsApp
{
    public partial class MainPage : ContentPage
    {
        public Employee bobby = new Employee()
        {
            Name = "Bobby",
            Age = 25
        };
        public MainPage()
        {
            InitializeComponent();

            //Label labelHello = new Label();
            //Entry entryHello = new Entry();

            ////labelHello.BindingContext = entryHello;
            ////labelHello.SetBinding(Label.TextProperty, "Text");

            //Binding bindingHello = new Binding();
            //bindingHello.Source = entryHello;
            //bindingHello.Path = "Text";

            //labelHello.SetBinding(Label.TextProperty, bindingHello);

            //stackLayout.Children.Add(labelHello);
            //stackLayout.Children.Add(entryHello);



            //
            //TagLabel tagLabel = new TagLabel();
            //Entry entry = new Entry();

            //tagLabel.BindingContext = entry;
            //tagLabel.SetBinding(TagLabel.TextProperty, "Text");
            //tagLabel.SetBinding(TagLabel.TagProperty, "Text");

            //Label targetLabel = new Label();
            //targetLabel.BindingContext = tagLabel;
            //targetLabel.SetBinding(Label.TextProperty, "Tag");

            //stackLayout.Children.Add(tagLabel);
            //stackLayout.Children.Add(entry);
            //stackLayout.Children.Add(targetLabel);



            //
            //Entry entrySource = new Entry();
            //Entry entryTarget = new Entry();

            //entryTarget.BindingContext = entrySource;
            //entryTarget.SetBinding(Entry.TextProperty, "Text", BindingMode.OneWayToSource);
            //stackLayout.Children.Add(entrySource);
            //stackLayout.Children.Add(entryTarget);


            //
            //Employee bobby = new Employee()
            //{
            //    Name = "Bobby",
            //    Age = 25
            //};
            //Label labelName = new Label();
            //Label labelAge = new Label();

            //Entry entryName = new Entry();
            //Entry entryAge = new Entry();

            //Binding bindingName = new Binding()
            //{
            //    Source = bobby,
            //    Path = "Name"
            //};

            //Binding bindingAge = new Binding()
            //{
            //    Source = bobby,
            //    Path = "Age"
            //};

            //labelName.SetBinding(Label.TextProperty, bindingName);
            //labelAge.SetBinding(Label.TextProperty, bindingAge);

            //stackLayout.Children.Add(labelName);
            //stackLayout.Children.Add(labelAge);

            //Binding bindingEditName = new Binding()
            //{
            //    Source = bobby,
            //    Path = "Name",
            //    Mode = BindingMode.TwoWay,
            //};

            //Binding bindingEditAge = new Binding()
            //{
            //    Source = bobby,
            //    Path = "Age",
            //    Mode = BindingMode.TwoWay,
            //};

            //entryName.SetBinding(Entry.TextProperty, bindingEditName);
            //entryAge.SetBinding(Entry.TextProperty, bindingEditAge);

            //stackLayout.Children.Add(entryName);
            //stackLayout.Children.Add(entryAge);

            //Button buttonShow = new Button();
            //buttonShow.Text = "Show Employee";
            //buttonShow.Clicked += (sender, e)
            //    => DisplayAlert("Employee show", $"{bobby.Name} {bobby.Age}", "Ok");

            //stackLayout.Children.Add(buttonShow);

            labelName.BindingContext = bobby;
            labelAge.BindingContext = bobby;
            entryName.BindingContext = bobby;
            entryAge.BindingContext = bobby;
        }

    }
}
