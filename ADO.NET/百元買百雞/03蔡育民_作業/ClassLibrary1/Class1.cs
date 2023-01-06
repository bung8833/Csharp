using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Aws()
        {           
            string aws = string.Empty;
            for(int rooster = 1; rooster < 20; rooster++)
            {
                for(int hen = 1; hen < 31; hen++)
                {
                    for(int chick = 3; chick < 95; chick += 3)
                    {
                        int Rprice = 5 * rooster, Hprice = 3 * hen, Cprice = chick / 3;
                        int all = rooster + hen + chick, allprice = Rprice + Hprice + Cprice;
                        if (all == 100 && allprice == 100)
                        {
                            aws += ($"當公雞為{rooster}隻，母雞為{hen}隻，小雞為{chick}隻時剛好花費100塊並且總數為100隻\a\n");
                        }
                    }
                }
            }
            return aws;
        }
    }
}
