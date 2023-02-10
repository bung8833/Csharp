using prjMAUIDemo.Models;
using prjMAUIDemo.View;
using prjMAUIDemo.View.TodoListDemo;
using static System.Net.Mime.MediaTypeNames;

namespace prjMAUIDemo;

public partial class App : Application
{
	public string Keyword { get; set; }
	public int SelectedCustomerIndex { get; set; }

	public List<Customer> Customers { get; set; }


	public App()
	{
		InitializeComponent();

        //MainPage = new NavigationPage(new PageEditor());
        //MainPage = new PageTodo();
        MainPage = new NavigationPage(new PageTodo());
    }
}
