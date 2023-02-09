namespace prjMAUIDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        btnShuffle.Clicked += BtnShuffle_Clicked;
        Shuffle();
    }

    public void Shuffle()
    {
        int labelCount = 4;

        List<string> colors = new List<string> { "紅", "藍", "黃", "綠" };
        List<string> result = new List<string> { };

        Label[] labels = new Label[] { lbl1, lbl2, lbl3, lbl4 };
        lbl1.Text = "紅"; lbl2.Text = "藍"; lbl3.Text = "黃"; lbl4.Text = "綠";

        // fill in result: colors of random order
        for (int i = 0; i < labelCount; i++)
        {
            Random seed = new Random(Guid.NewGuid().GetHashCode());
            int index = seed.Next(0, labelCount - i);

            result.Add(colors[index]);
            colors.RemoveAt(index);
        }

        // change text of labels
        for (int i = 0; i < labelCount; i++)
        {
            labels[i].Text = result[i];
        }
    }

    private void BtnShuffle_Clicked(object sender, EventArgs e)
    {
        Shuffle();
    }
}

