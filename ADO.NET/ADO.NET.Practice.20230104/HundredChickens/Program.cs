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
            int x; // 公雞  5元/ 隻
            int y; // 母雞  3元/ 隻
            int z; // 小雞  1元/3隻    z代表要買多少組3隻的小雞
            string result = String.Empty;

            int loopCount = 0;

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

                    loopCount++;
                }
            }

            Console.WriteLine($"\n共跑了{loopCount}次迴圈");
            Console.ReadKey();
        }
    }
}
