namespace ISpan2023.EStore.SqlDataLayer.Extensions
{
	public static class StringExtensions
	{
		public static int? TryParseInt32(this string source)
		{
			return int.TryParse(source, out int value)
				? value
				: (int?)null;
		}
	}
}