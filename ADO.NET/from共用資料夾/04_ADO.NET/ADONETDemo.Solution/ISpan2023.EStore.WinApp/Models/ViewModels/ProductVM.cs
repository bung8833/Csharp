using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ISpan2023.EStore.SqlDataLayer;

namespace ISpan2023.EStore.WinApp.Models.ViewModels
{
	public class ProductVM
	{
		public int Id { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "必填")]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "必填")]
		[StringLength(50, ErrorMessage = "不可超過 50 個字")]
		public string Name { get; set; }

		[Required(ErrorMessage = "必填")]
		public string Description { get; set; }

		[Required(ErrorMessage = "必填")]
		[Range(0, int.MaxValue, ErrorMessage = "必需填零或正整數")]
		public int? Price { get; set; }

		[Required(ErrorMessage = "必填")]
		public bool? Status { get; set; }

		[Required(ErrorMessage = "必填")]
		[StringLength(50, ErrorMessage = "不可超過 70 個字")]
		public string ProductImage { get; set; }

		[Required(ErrorMessage = "必填")]
		[Range(0, int.MaxValue, ErrorMessage = "必需填零或正整數")]
		public int? Stock { get; set; }
	}

	public static class ProductVMExtenstions
	{
		public static ProductEntity ToEntity(this ProductVM vm)
		{
			return new ProductEntity()
			{
				CategoryId = vm.CategoryId,
				Name = vm.Name,
				Description = vm.Description,
				Price = vm.Price.Value,
				Status = vm.Status.Value,
				Stock = vm.Stock.Value,
				ProductImage = vm.ProductImage
			};
		}
	}
}