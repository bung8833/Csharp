namespace prjMAUIDemo.View;

public partial class PageKeyword : ContentPage
{
	public PageKeyword()
	{
		InitializeComponent();
		
		this.Loaded += PageKeyword_Loaded;
    }

	private void PageKeyword_Loaded(object sender, EventArgs e)
	{
        txtKeyword.Focus();
    }

	private void btnOKClicked(object sender, EventArgs e)
	{
        App app = Application.Current as App;
        app.Keyword = txtKeyword.Text;

		Navigation.PopAsync();
    }
}