using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.Csharp.practice
{
    public class Order
    {
        public static int ClacTax(int Price)
        {
            return Price / 20; // 營業稅 5%
        }
    }
}
