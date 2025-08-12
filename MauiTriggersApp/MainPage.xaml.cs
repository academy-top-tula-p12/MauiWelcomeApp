namespace MauiTriggersApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            //Entry entryText = new Entry()
            //{
            //    TextColor = Colors.Pink,
            //    Text = "Hello world",
            //};

            //Trigger triggerFocused = new Trigger(typeof(Entry))
            //{
            //    Property = IsFocusedProperty,
            //    Value = true,
            //};

            //triggerFocused.Setters.Add(
            //    new Setter()
            //    {
            //        Property = Entry.TextColorProperty,
            //        Value = Colors.DarkRed,
            //    });

            //entryText.Triggers.Add(triggerFocused);

            //stackLayout.Children.Add(entryText);


            //Entry entryNumber = new Entry();
            //EventTrigger triggerValidation = new EventTrigger()
            //{
            //    Event = "TextChanged",
            //};
            //triggerValidation.Actions.Add(new EntryNumberValidation());
            //entryNumber.Triggers.Add(triggerValidation);

            //stackLayout.Children.Add(entryNumber);

            //DataTrigger dataTrigger = new DataTrigger(typeof(Button));
            //dataTrigger.Binding = new Binding()
            //{
            //    Source = entryData,
            //    Path = "Text.Length",
            //};
            //dataTrigger.Value = 0;

            //dataTrigger.Setters.Add(new Setter()
            //{
            //    Property = Button.IsEnabledProperty,
            //    Value = false
            //});

            //buttonDataSave.Triggers.Add(dataTrigger);
        }
    }
}
