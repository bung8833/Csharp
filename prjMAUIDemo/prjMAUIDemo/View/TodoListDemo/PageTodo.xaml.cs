namespace prjMAUIDemo.View.TodoListDemo;

public partial class PageTodo : ContentPage
{
	public PageTodo()
	{
		InitializeComponent();
	}

	private void btnSaveClicked(object sender, EventArgs e)
	{
		// ���o�y���� �M���y��������+1
        string srNStr = Preferences.Default.Get("Count", "N/A");
        if (srNStr == "N/A")
        {
            Preferences.Default.Set("Count", "1");
            srNStr = Preferences.Default.Get("Count", "N/A");
        }

		int srN = Convert.ToInt32(srNStr);
		srN++;
        Preferences.Default.Set("Count", srN.ToString());

		// �x�s�ݿ�ƶ�
		string keyT = "T" + srN.ToString();
		Preferences.Default.Set(keyT, txtTodo.Text);
		txtTodo.Text = String.Empty;

        string keyD = "D" + srN.ToString();
        Preferences.Default.Set(keyD, txtDate.Text);
        txtDate.Text = String.Empty;
    }

	private void btnListClicked(object sender, EventArgs e)
	{
        //App app = Application.Current as App;
        //app.Customers = vm.Customers;

        Navigation.PushAsync(new PageTodoList());
    }
}