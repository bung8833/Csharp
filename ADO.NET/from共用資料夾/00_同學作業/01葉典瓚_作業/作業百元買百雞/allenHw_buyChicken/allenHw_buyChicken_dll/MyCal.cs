using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allenHw_buyChicken_dll
{
    public class MyCal
    {
        public static int RoosterNum;
        public static int henNum;
        public static int chickGroup;
        public static int chickNum;

        public static string CalG()
        {
            // 想法1:3個loop 若超過則跳出迴圈
            // 想法2:用字典算?
            Dictionary<int, int> mapMoney = new Dictionary<int, int>();
            Dictionary<int, int> mapQuantity = new Dictionary<int, int>();
            //for (RoosterNum = 1; ) { 


            for (RoosterNum = 0; RoosterNum < 21; RoosterNum++) {
                int q = 100 - RoosterNum;
                int m = 100 - (5 * RoosterNum);
                henNum = (3 * m - q) / 8;
                chickGroup = (3 * q - m) / 8;
                // $"RoosterNum: {RoosterNum}, henNum: {henNum}, chickGroup:{chickGroup} ";


            }

            if (RoosterNum * 5 + henNum * 3 + chickGroup == 100 &&
                RoosterNum + henNum + chickGroup * 3 == 100
            )
            {
                return $"RoosterNum: {RoosterNum}, henNum: {henNum}, chickGroup:{chickGroup} ";
            }



            return null;
        }
    }
}
