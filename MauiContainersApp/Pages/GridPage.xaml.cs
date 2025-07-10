namespace MauiContainersApp.Pages;

public partial class GridPage : ContentPage
{
	public GridPage()
	{
		InitializeComponent();

		Grid grid = new Grid()
		{
			ColumnSpacing = 10,
			ColumnDefinitions =
			{
				new ColumnDefinition(){ Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition(){ Width = new GridLength(3, GridUnitType.Star) },
                new ColumnDefinition(){ Width = new GridLength(2, GridUnitType.Star) },
            }
		};

		grid.RowDefinitions = new RowDefinitionCollection
		{
			new RowDefinition(){ Height = new GridLength(2, GridUnitType.Star) },
            new RowDefinition(){ Height = new GridLength(1, GridUnitType.Star) },
        };
		grid.RowSpacing = 20;

		BoxView boxViewPink = new BoxView()
		{
			Color = Colors.HotPink,
		};
		grid.Add(boxViewPink, 1, 0);

        BoxView boxViewViolet = new BoxView()
        {
            Color = Colors.Violet,
        };
        grid.Add(boxViewViolet, 0, 1);
		Grid.SetColumnSpan(boxViewViolet, 2);

        BoxView boxViewYellow = new BoxView()
        {
            Color = Colors.Yellow,
        };
        grid.Add(boxViewYellow, 2, 0);
        Grid.SetRowSpan(boxViewYellow, 2);


        Content = grid;
	}
}