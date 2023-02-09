using prjMAUIDemo.Models;

namespace prjMAUIDemo;

public partial class PageLottery : ContentPage
{
	public PageLottery()
	{
		InitializeComponent();

		btnGenerate.Clicked += BtnGenerate_Clicked;
		btnClear.Clicked += BtnClear_Clicked;

		lblLottery.Text = String.Empty;
        Display();
	}

	private void BtnGenerate_Clicked(object sender, EventArgs e)
	{
		Display();
	}

	private void BtnClear_Clicked(object sender, EventArgs e)
	{
        lblLottery.Text = String.Empty;
    }

	public void Display()
	{
		int numberCount = 6;

        List<int> lotteryNumbers = 
			new LotteryNumberGenerator().GetNumber(numberCount);

        // modify text
        string result = String.Empty;

        for (int i = 0; i < numberCount; i++)
        {
			result += lotteryNumbers[i] < 10
					  ? $"0{lotteryNumbers[i]}   "
					  : $"{lotteryNumbers[i]}   ";
        }

		lblLottery.Text = $"{result}\r\n" + lblLottery.Text;
	}
}