using prjMAUIDemo.Models;
using prjMAUIDemo.Models.ViewModels;
using System.Diagnostics.Metrics;

namespace prjMAUIDemo.View;

public partial class PageEditor : ContentPage
{
	CustomerVM vm = new CustomerVM();

	public PageEditor()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		App app = Application.Current as App;

		if ( !String.IsNullOrEmpty(app.Keyword) )
		{
			if ( vm.QueryByKeyword(app.Keyword) != null )
			{
				DisplayCustomerInfo();
			}
		}
		else if (app.SelectedCustomerIndex >= 0)
		{
			vm.MoveTo(app.SelectedCustomerIndex);
			DisplayCustomerInfo();
		}
	}

	private void DisplayCustomerInfo()
	{
        txtId.Text = vm.CurrentCustomer.Id.ToString();
        txtName.Text = vm.CurrentCustomer.Name;
        txtPhone.Text = vm.CurrentCustomer.Phone;
        txtEmail.Text = vm.CurrentCustomer.Email;
        txtAddress.Text = vm.CurrentCustomer.Address;
    }

	private void btnFirst_Clicked(object sender, EventArgs e)
	{
		vm.MoveFirst();

        DisplayCustomerInfo();
    }

	private void btnPrevious_Clicked(object sender, EventArgs e)
	{
		vm.MovePrevious();

        DisplayCustomerInfo();
    }

	private void btnNext_Clicked(object sender, EventArgs e)
	{
		vm.MoveNext();

        DisplayCustomerInfo();
    }

	private void btnLast_Clicked(object sender, EventArgs e)
	{
		vm.MoveLast();

        DisplayCustomerInfo();
    }

	private void btnQuery_Clicked(object sender, EventArgs e)
	{
        App app = Application.Current as App;
        ClearCache();

		Navigation.PushAsync(new PageKeyword());
	}

	private void ClearCache()
	{
        App app = Application.Current as App;
        app.Keyword = String.Empty;
		app.SelectedCustomerIndex = -1;
	}

	private void btnList_Clicked(object sender, EventArgs e)
	{
		App app = Application.Current as App;
		app.Customers = vm.Customers;

		ClearCache();

		Navigation.PushAsync(new PageList());
	}
}