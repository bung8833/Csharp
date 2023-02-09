namespace prjMAUIDemo.View;

public partial class PagePreferencesDemo : ContentPage
{
	public PagePreferencesDemo()
	{
		InitializeComponent();
	}

	private void btnSaveClicked(object sender, EventArgs e)
	{
		Preferences.Default.Set("KK", txtSet.Text);
	}

	private void btnReadClicked(object sender, EventArgs e)
	{
		lblGet.Text = Preferences.Default.Get("KK", "沒有資料");
	}
}