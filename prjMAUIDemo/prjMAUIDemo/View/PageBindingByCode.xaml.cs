namespace prjMAUIDemo.View;

public partial class PageBindingByCode : ContentPage
{
	public PageBindingByCode()
	{
		InitializeComponent();

		label.BindingContext = slider;
		label.SetBinding(Label.FontSizeProperty, "Value");
	}
}