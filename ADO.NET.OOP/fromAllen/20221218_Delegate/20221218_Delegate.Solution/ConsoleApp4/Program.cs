using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            member.DataChanged += Member_DataChanged;
            member.Name = "Allen";

            Member member2 = new Member();
            member2.DataChanged += Member_DataChanged;
            member2.Name = "Simon";

        }

        private static void Member_DataChanged(object sender, DateTime dt)
        {
            Member member = sender as Member;
            Console.WriteLine("事件被觸發了,Name=" + member.Name + " @" + dt);
        }
    }
       
    public delegate void DataChangedEventHandler(object sender, DateTime dt);
    public class Member
    {
        public event DataChangedEventHandler DataChanged;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Name不能是null");
                if (value.Length > 30) throw new Exception("Name長度不能超過30");

                _name = value;
                
                OnDataChanged(DateTime.Now);
            }
        }
        protected virtual void OnDataChanged(DateTime arg)
        {
            // raise event
            if (DataChanged != null) DataChanged(this, arg);
        }
    }
    //public class VIP : Member
    //{
    //    private string _email;
    //    public string Email
    //    {
    //        get { return _email; }
    //        set
    //        {
    //            _email = value;

    //            // raise event
    //            OnDataChanged();
    //        }
    //    }

    //    //protected override void OnDataChanged()
    //    //{
    //    //    // base.OnDataChanged();
    //    //}
    //}
}
