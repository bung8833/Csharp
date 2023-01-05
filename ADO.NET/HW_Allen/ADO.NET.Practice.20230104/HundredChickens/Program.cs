using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredChickens
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Plan> CalcMethod()
            {
                Plan purchasePlan = new Plan();
                List<Plan> purchasePlanList = new List<Plan>();

                return purchasePlanList;
            }


            #region
            int x; // 公雞
            int y; // 母雞
            int z; // z代表要買多少組3隻的小雞
            string result = String.Empty;

            // 公雞  5元/ 隻
            // 母雞  3元/ 隻
            // 小雞  1元/3隻

            // x + y + 3z = 100
            // 5x + 3y + z = 100

            for (x = 0; x < 20; x++) {
                for (y = 0; 5*x + 3*y <= 100; y++)
                {
                    z = 100 - 5*x - 3*y;

                    if (x + y + 3*z == 100)
                    {
                        result = $"公雞: {x, 2}隻\t母雞: {y, 2}隻\t小雞: {3*z, 2}隻({z, 2}組)";
                        Console.WriteLine(result);
                    }
                }
            }
            #endregion

            Console.ReadLine();
        }
    }

    public class Plan
    {
        public int RoosterCount { get; set; }
        public int HenCount { get; set; }
        public int ChickCount { get; set; }
    }

    public class Product
    {
        //todo
    }
}
