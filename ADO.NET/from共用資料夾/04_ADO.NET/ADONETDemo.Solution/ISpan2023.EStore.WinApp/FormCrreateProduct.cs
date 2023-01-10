using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan2023.EStore.WinApp.Models.ViewModels;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using ISpan2023.EStore.SqlDataLayer.Extensions;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormCrreateProduct : Form
	{
		public FormCrreateProduct()
		{
			InitializeComponent();

			this.Load +=FormCrreateProduct_Load;
		}

		private void FormCrreateProduct_Load(object sender, EventArgs e)
		{
			BindCategories();

		}

		private void BindCategories()
		{
			var items = new CategoryRepository().Search().Prepend(new Category()).ToList();

			comboBoxCategoryId.DisplayMember = "Name";
			comboBoxCategoryId.ValueMember = "Id";
			comboBoxCategoryId.DataSource = items;
		}

		private int CategoryId => ((Category)this.comboBoxCategoryId.SelectedItem).Id;

		private int? Price => textBoxPrice.Text.TryParseInt32();

		private int? Stock => textBoxStock.Text.TryParseInt32();

		private bool? Status
		{
			get
			{
				if (radioButtonStatus1.Checked) return true;
				if (radioButtonStatus0.Checked) return false;
				return null;
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			//var entity = new ProductEntity()
			//{
			//	CategoryId = this.CategoryId,
			//	Name = textBoxName.Text,
			//	Description = textBoxDescription.Text,
			//	Price = this.Price,
			//	Status = this.Status,
			//	Stock = this.Stock,
			//	ProductImage = textBoxImage.Text
			//};

			// model binding
			var vm = new ProductVM()
			{
				CategoryId = this.CategoryId,
				Name = textBoxName.Text,
				Description = textBoxDescription.Text,
				Price = this.Price,
				Status = this.Status,
				Stock = this.Stock,
				ProductImage = textBoxImage.Text
			};

			// 用Data Annotation 針對 view model 做欄位驗證
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			// 如果有錯誤就顯示錯誤訊息
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 若沒錯誤就將VM轉型為Entity後,執行建檔工作
			ProductEntity entity = vm.ToEntity();
			try
			{
				var rowsAffected = new ProductRepository().Create(entity);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗, 原因:{ex.Message}");
				return;
			}

			IGridContainer container = this.Owner as IGridContainer;
			container.Display();

			this.DialogResult = DialogResult.OK;
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"CategoryId", comboBoxCategoryId},
				{"Name", textBoxName},
				{"Description", textBoxDescription},
				{"Price", textBoxPrice},
				{"Status", panel1},
				{"ProductImage", textBoxImage},
				{"Stock", textBoxStock}

			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private (bool isValid, List<ValidationResult> errors) Validate(ProductVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
	}
}
