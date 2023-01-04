using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredChickens
{
    public class Program
    {
        // 100元  買100隻雞
        // 公雞   5元/ 隻
        // 母雞   3元/ 隻
        // 小雞   1元/3隻

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int price = 0;

            while (x + y + z != 100)
            {
                x += 1;
                while (x + y + z != 100)
                {
                    y += 1;
                    while (x + y + z != 100)
                    {
                        z += 1;
                    }
                }
            }
        }
    }
}
