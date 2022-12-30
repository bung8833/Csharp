using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.LeaveSystem.Utilities.UnitTests
{
    internal class TaiwanStockUtilityTests
    {
        [TestCase("2022/12/16 9:00:00")]
        [TestCase("2022/12/16 13:30:00")]
        [TestCase("2022/12/12 9:00:00")]
        [TestCase("2022/12/12 13:30:00")]
        public void IsTradingHours_是交易時間(string dtValue)
        {
            DateTime dt = Convert.ToDateTime(dtValue);

            bool actual = TaiwanStockUtility.IsTradingHours(dt);

            Assert.IsTrue(actual);
        }

        [TestCase("2022/12/16 8:59:59")]
        [TestCase("2022/12/16 13:30:01")]
        [TestCase("2022/12/12 8:59:59")]
        [TestCase("2022/12/12 13:30:01")]
        public void IsTradingHours_是平日_但不是交易時間_ReturnsFalse(string dtValue)
        {
            DateTime dt = Convert.ToDateTime(dtValue);

            bool actual = TaiwanStockUtility.IsTradingHours(dt);

            Assert.IsFalse(actual);
        }


        [TestCase("2022/12/17 9:00:00")]
        [TestCase("2022/12/17 13:30:00")]
        [TestCase("2022/12/18 9:00:00")]
        [TestCase("2022/12/18 13:30:00")]
        public void IsTradingHours_星期六日_但時間交易時間_ReturnsFalse(string dtValue)
        {
            DateTime dt = Convert.ToDateTime(dtValue);

            bool actual = TaiwanStockUtility.IsTradingHours(dt);

            Assert.IsFalse(actual);
        }
    }
}
