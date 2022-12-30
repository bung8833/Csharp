using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee eng = new Engineer { Name = "Allen", Gender = true, BadgeNumber = "005" };
            Create(eng);

            Engineer eng4 = new Engineer { Name = "Allen", Gender = true, BadgeNumber = "005" };
            Create(eng4);
            

            //IEmployee eng2 = new Sales { Name = "Allen", Gender = true, BadgeNumber = "005" };
            //Create(eng2);

            //IEmployee eng3 = new Manager { Name = "Allen", Gender = true, BadgeNumber = "005" };
            //Create(eng3);
        }

        static IEmployee SearchEmployeeById(int id) //去database 根據id找出一個員工
        {
            throw new NotImplementedException();
        }
        static void Create(IEmployee emp)
        {
            string name = emp.Name;
            bool gender = emp.Gender;
            string badgeNumber = emp.BadgeNumber;
            
        }

        //static void Create(Engineer emp)
        //{
        //    string name = emp.Name;
        //    bool gender = emp.Gender;
        //    string badgeNumber = emp.BadgeNumber;
        //}
        //static void Create(Sales emp)
        //{
        //    string name = emp.Name;
        //    bool gender = emp.Gender;
        //    string badgeNumber = emp.BadgeNumber;
        //}
        //static void Create(Manager emp)
        //{
        //    string name = emp.Name;
        //    bool gender = emp.Gender;
        //    string badgeNumber = emp.BadgeNumber;
        //}


        //static void Create(IEmployee emp)
        //{
        //    string name = emp.Name;
        //    bool gender = emp.Gender;
        //    string badgeNumber = emp.BadgeNumber;
        //}
    }
    public interface IEmployee
    {
        string BadgeNumber { get; set; } // 員工編號, 工號
        string Name { get; set; }
        bool Gender { get; set; }
    }

    public class Engineer : IEmployee
    {
        public string BadgeNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime DateOfBirth { get; set; }
    }
    public class Sales : IEmployee
                       {
        public string BadgeNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
        public int Bonus { get; set; } // 紅利
    }
    public class Manager : IEmployee 
    {

        public string BadgeNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
        public List<IEmployee> TeamMembers { get; set; }
    }
}
