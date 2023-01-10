using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Windows.Forms;
using ISpan2023.EStore.SqlDataLayer;

namespace ISpan2023.EStore.WinApp
{
	public static class ComboBoxExtensions
	{
		/// <summary>
		/// 設定 combobox值
		/// </summary>
		/// <param name="source"></param>
		/// <param name="value"></param>
		/// <param name="predicate"></param>
		public static void SetValue(this ComboBox source, string value,
							Func<string, object, bool> predicate)
		{
			int idx = 0;
			foreach (var item in source.Items)
			{
				if (predicate(value, item))
				{
					source.SelectedIndex = idx;
					return;
				}

				idx++;
			}
		}
	}
}