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
        }
    }

    public class Member {
        public string Name; // Field or Property
        // public DateTime DateOfBirth { get; set; } // property

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public void Create() { //Method
        
        }
    }

    //介面
    public interface IMember { 
        // no Field, 也沒有建構函數
        DateTime DateTime { get; set; } // 不可以寫public, protected or private

        void Create(); // 不可以寫public, 也不可以寫大括號,當然也不能寫程式碼
    }
}
