using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {/*計算車資
      男,    大於70,       2元
      女,    大於65,       3元
      兒童,   小於等於3,    1元
      標準,               15元
        */
        static void Main(string[] args)
        {
            bool gender = true; // 男
            int age = 70;
            int fee = 0; //車資

            if (gender == true) // 男性
            {
                if(age > 70)
                {
                    fee = 2;
                }
                else if(age <=3) //兒童
                {
                    fee = 1;
                }
                else // 標準
                {
                    fee = 15;
                }

            }
            else // 女性
            {
                if (age > 65)
                {
                    fee = 3;
                }
                else if (age <= 3) //兒童
                {
                    fee = 1;
                }
                else // 標準
                {
                    fee = 15;
                }

            }
        }
    }
}
