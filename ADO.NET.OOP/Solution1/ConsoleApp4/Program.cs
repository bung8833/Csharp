using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();

            //// 註冊事件
            //// 最後 tab tab
            member.DataChanged += Member_DataChanged1;

            member.Name = "Richard";
            member.Name = "Robert";

            //VIP vip = new VIP();
            //vip.DataChanged += Vip_DataChanged;

            //vip.Name = "Anna";

            Console.ReadKey();
        }

        private static void Member_DataChanged1(object sender, DateTime dt)
        {
            // sender.Name
            Console.WriteLine($"Event fired by {sender}, @ {dt}");
        }

        private static void Vip_DataChanged()
        {
            Console.WriteLine("VIP Event fired");
        }

        private static void Member_DataChanged()
        {
            Console.WriteLine("Event fired");
        }

        // 先宣告委派
        public delegate void DataChangedEventHandler(object sender, DateTime dt);

        public class Member
        {
            //public     int                Id;

            // 再宣告事件
            public event DataChangedEventHandler DataChanged;

            private string _name;

            public string Name
            {
                get { return _name; }
                set 
                { 
                    // 驗證

                    
                    _name = value;

                    // raise event 即在set Name時觸發Event
                    //if (DataChanged != null) DataChanged(); // 記得判斷
                    OnDataChanged(DateTime.Now);
                }
            }

            protected virtual void OnDataChanged(DateTime arg) //子類別可以改
            {
                if (DataChanged != null) DataChanged(this, arg);
            }
        }

        public class VIP : Member
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    // 驗證


                    _name = value;

                    // raise event 即在set Name時觸發Event
                    //if (DataChanged != null) DataChanged(); // 記得判斷
                    OnDataChanged(DateTime.Now);
                }
            }

            // override時 tab
            protected override void OnDataChanged(DateTime arg)
            {
                base.OnDataChanged(arg);
            }
        }
    }
}
