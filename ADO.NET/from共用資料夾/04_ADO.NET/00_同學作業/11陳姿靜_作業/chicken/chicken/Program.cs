using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace chicken
{
    public class Program
    {
        static void Main(string[] args)
        {
               for(int Rooster=1; Rooster <20; Rooster++)
               {
                  for(int hen=1;hen <33; hen++)
                  {
                      for(int chick=1; chick <100; chick++)
                      {
                         if ((Rooster + hen + chick == 100) && (Rooster*5 + hen*3 + chick/3 == 100) && (chick%3==0))
                         {
                            Console.WriteLine("公雞:" + Rooster + ",母雞:" + hen + ",小雞:" + chick);
                         }


                      }
                  }
               }


        }


    }
}
