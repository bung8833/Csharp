using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            member.Name = "Allen";
            string greeting = member.Greet("Hello"); // Hello, Allen

            Member member2 = new Member();
            string greeting2 = member2.Greet("Hello"); // Hello


        }
    }

    public class Member
    {
        public string Name { get; set; }

        /// <summary>
        /// 傳回 'Hello, Allen'
        /// 如果 Name 沒有值, 傳回 'Hello'
        /// </summary>
        /// <param name="greeting"></param>
        /// <returns></returns>
        public string Greet(string greeting) {
            throw new NotImplementedException();
        }

    }
}
