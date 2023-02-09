namespace prjMAUIDemo.View.TodoListDemo;

public partial class PageTodoList : ContentPage
{
	public PageTodoList()
	{
		InitializeComponent();

        lvTodoList.ItemsSource = new List<string>() { "one", "two", "three" };

        string result = String.Empty;
        string record = String.Empty;

        for (int srN = 100; srN > -1; srN--)
        {
            record = String.Empty;
            record += Preferences.Default.Get("T" + srN.ToString(), String.Empty) + "\r\n";
            record += Preferences.Default.Get("D" + srN.ToString(), String.Empty) + "\r\n";

            if (!record.StartsWith("\r\n"))
            {
                result += "-" + record;
            }
        }

        lblTodoList.Text = result;
    }

	private void lvTodoList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
        //if (e.SelectedItemIndex < 0) return;

        //App app = Application.Current as App;
        //app.SelectedCustomerIndex = e.SelectedItemIndex;
        //Navigation.PopAsync();
    }
}