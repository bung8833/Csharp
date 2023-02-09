namespace prjMAUIDemo.View;

public partial class PageClickDemo : ContentPage
{
	public PageClickDemo()
	{
		InitializeComponent();
	}

	private void ButtonOkClicked(object sender, EventArgs e)
	{
		double a = double.Parse(EntryA.Text);
        double b = double.Parse(EntryB.Text);
        double c = double.Parse(EntryC.Text);

		double r = Math.Sqrt( b * b - 4 * a * c );

		double ans1 = (-b + r) / (a * 2);
        double ans2 = (-b - r) / (a * 2);

		LabelAnswer.Text = $" x = {Math.Round(ans1, 2, MidpointRounding.AwayFromZero)}" 
					     + $"  ©Î  {Math.Round(ans2, 2, MidpointRounding.AwayFromZero)}";


    }
}