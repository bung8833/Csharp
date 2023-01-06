using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken.Solution
{
    class Program
    {
        //Rooster 公雞
        //Hen 母雞
        //Chick 小雞
        static void Main(string[] args)
        {
            int rooster = 20, hen = 0, chick = 0;
            bool minusChk;

            while (!(rooster == 0 && hen == 0))
            {
                //確認下一輪是否要減少購買母雞的數量
                minusChk = true;
                //確認下一輪是否要減少購買公雞的數量
                if (hen == 0)
                {
                    rooster--;
                    hen = 100;
                }
                int wallet = 100;

                //減去購買公雞的錢
                wallet -= rooster * 5;

                //減去購買母雞的錢
                if (hen == 100)
                {
                    hen = wallet / 3;
                    chick = wallet % 3;
                    minusChk = false;
                }
                else 
                {
                    wallet -= hen * 3;
                    chick = wallet;
                }

                //顯示結果
                if (NumCheck(rooster, hen, chick)) ShowResult(rooster,hen,chick);
                if (minusChk) hen--;
            }

            Console.ReadKey();
        }

        public static void ShowResult(int rooster, int hen, int chick)
        {
            Console.WriteLine($"公雞買{rooster}隻\n母雞買{hen}隻\n小雞買{chick}組，{chick * 3}隻\n");
        }

        //確認總計100雞
        public static bool NumCheck(int rooster, int hen, int chick) => rooster + hen + chick * 3 == 100;
    }
}
