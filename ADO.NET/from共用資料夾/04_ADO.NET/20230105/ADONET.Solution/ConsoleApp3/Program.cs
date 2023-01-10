using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// string a = "ABC \" DEF";
			string b = "D:\temp\a.jpg";
			string c = "d:\\temp\\a.jpg";
			string c2 = @"d:\temp\a.jpg";
			string c3 = @"ABC "" DEF";
			string c4 = @"line 1
line 2
line 3
	line 4";
			string html = @" <div class=""txt-cell txt-top txt-left"">
                                <span><a target=""_blank"" rel=""noopener"" href=""http://sms.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_sms"" data-tabsid=""http://sms.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_sms"" data-linkdef=""左方頻道列_4_0_a"">一元簡訊</a><a data-linkdef=""左方頻道列_4_0_b""></a></span>
                                <span><a target=""_blank"" rel=""noopener"" href=""http://live.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_live"" data-tabsid=""http://live.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_live"" data-linkdef=""左方頻道列_4_1_a"">直播達人</a><a data-linkdef=""左方頻道列_4_1_b""></a></span>
                                <span><a target=""_blank"" rel=""noopener"" href=""https://pchome-ssl.cloudmax.com.tw/?utm_source=portalindex&utm_medium=menu_ssl"" data-tabsid=""https://pchome-ssl.cloudmax.com.tw/?utm_source=portalindex&utm_medium=menu_ssl"" data-linkdef=""左方頻道列_4_2_a"">數位憑證</a><a data-linkdef=""左方頻道列_4_2_b""></a></span>
                                <span><a target=""_blank"" rel=""noopener"" href=""http://office-sms.pchomebiz.com.tw/index.html?utm_source=portalindex&utm_medium=menu_osms"" data-tabsid=""http://office-sms.pchomebiz.com.tw/index.html?utm_source=portalindex&utm_medium=menu_osms"" data-linkdef=""左方頻道列_4_3_a"">企業簡訊</a><a data-linkdef=""左方頻道列_4_3_b""></a></span>
                                <span><a target=""_blank"" rel=""noopener"" href=""http://myname.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_myname"" data-tabsid=""http://myname.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_myname"" data-linkdef=""左方頻道列_4_4_a"">買網址</a><a data-linkdef=""左方頻道列_4_4_b""></a></span>
                                <span><a target=""_blank"" rel=""noopener"" href=""http://webhosting.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_host"" data-tabsid=""http://webhosting.pchomebiz.com.tw/?utm_source=portalindex&utm_medium=menu_host"" data-linkdef=""左方頻道列_4_5_a"">虛擬主機</a><a data-linkdef=""左方頻道列_4_5_b""></a></span>
                                <span><a target=""_blank"" rel=""noopener"" href=""http://webhosting.pchomebiz.com.tw/activity/officemail/index.html?utm_source=portalindex&utm_medium=menu_omail"" data-tabsid=""http://webhosting.pchomebiz.com.tw/activity/officemail/index.html?utm_source=portalindex&utm_medium=menu_omail"" data-linkdef=""左方頻道列_4_6_a"">企業郵件</a><a data-linkdef=""左方頻道列_4_6_b""></a></span>
                            </div>";
			string sql = @"SELECT P.Id, P.Name as ProductName, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories as C ON C.ID = P.CategoryId
Where
	C.Id = 1
ORDER BY C.DisplayOrder";

			Console.WriteLine(c4);
		}
	}
}
