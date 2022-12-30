using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member("Allen");

            string myName = member.Name; // Allen
            Console.WriteLine(myName);
        }
    }

    public class Member {
        public string Name { get; set; }

        public Member(string Name)
        {
            this.Name = Name;
        }
    }
}
