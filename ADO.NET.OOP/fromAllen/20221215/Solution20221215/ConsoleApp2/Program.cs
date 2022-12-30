using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var member = new Member();
        }
    }
    public class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Member(string name)
        {
            Name = name;
        }
    }

}
