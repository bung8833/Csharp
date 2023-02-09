using prjMAUIDemo.Models;

namespace prjMAUIDemo.View;

public partial class PageList : ContentPage
{
	public PageList()
	{
		InitializeComponent();

		App app = Application.Current as App;
		lvCustomer.ItemsSource = app.Customers;
	}

	private void lvCustomer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItemIndex < 0) return;

        App app = Application.Current as App;
		app.SelectedCustomerIndex = e.SelectedItemIndex;
		Navigation.PopAsync();
    }
}