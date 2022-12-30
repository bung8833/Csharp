using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.LeaveSystem.Utilities
{
    /// <summary>
    /// 與訂單相關的類別
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 計算5%營業稅,四捨五入到整數
        /// </summary>
        /// <param name="price">未稅金額</param>
        /// <returns>傳回營業稅</returns>
        public static int CalcTax(int price)
        {
            // return price / 20; // 營業稅 5%
            return (int)Math.Round((double)price / 20.0, MidpointRounding.AwayFromZero);
        }
    }
}
