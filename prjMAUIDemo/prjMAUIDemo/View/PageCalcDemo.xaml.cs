namespace prjMAUIDemo.View;

public partial class PageCalcDemo : ContentPage
{
	int prevTotal = 0;
	string prevOperator = String.Empty;

	public PageCalcDemo()
	{
		InitializeComponent();
	}

	private void btnNumbersClicked(object sender, EventArgs e)
	{
		int prevAns = Convert.ToInt32(LabelAnswer.Text);
		Button btn = sender as Button;

		if (prevAns == 0)
		{
			LabelAnswer.Text = btn.Text;
		}
		else
		{
			LabelAnswer.Text += btn.Text;
		}
	}

	private void btnOperatorsClicked(object sender, EventArgs e)
	{
		prevTotal = Convert.ToInt32(LabelAnswer.Text);
		LabelAnswer.Text = "0";

        Button btn = sender as Button;
        prevOperator = btn.Text;
	}

	private void btnEqualsClicked(object sender, EventArgs e)
	{
		// ¼g¦¨ +=
		int total = 0;

		if (prevOperator == "+")
		{
			total = prevTotal + Convert.ToInt32(LabelAnswer.Text);
        }
		else if (prevOperator == "-")
		{
            total = prevTotal - Convert.ToInt32(LabelAnswer.Text);
        }
        else if (prevOperator == "*")
        {
            total = prevTotal * Convert.ToInt32(LabelAnswer.Text);
        }
        else if (prevOperator == "/")
        {
			try
			{
                total = prevTotal / Convert.ToInt32(LabelAnswer.Text);
            }
			catch (Exception ex)
			{
				LabelAnswer.Text = "Division by Zero" + ex.Message;
            }
        }
		else
		{
			throw new Exception("No such operator");
		}

        LabelAnswer.Text = total.ToString();
    }
}