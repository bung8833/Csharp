using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Gender=true, Age = 71};
            customer = new Customer { Gender = false ,Age = 66 };
            customer = new Customer {  Age = 3 };
            customer = new Customer { Gender = true, Age = 18 };

            BaseHandler handler = InitHandlers();
            int fee = handler.ProcessRequest(customer);
            Console.WriteLine($"車資={fee}"); // 字串插值
        }
        static BaseHandler InitHandlers() {
            BaseHandler oldMan = new OldMan();
            BaseHandler oldWoman = new OldWoman();
            BaseHandler child = new Child();
            BaseHandler standard = new Standard();

            oldMan.Successor = oldWoman;
            oldWoman.Successor = child;
            child.Successor = standard;

            return oldMan;
        }
    }

    public abstract class BaseHandler
    {
        public BaseHandler Successor { get; set; } // 繼承者
        public int ProcessRequest(Customer customer)
        {
            if(CanHandle(customer) == true)
            {
                return CalcFee(customer);
            }
            else
            {
                if(Successor != null)
                {
                    return Successor.ProcessRequest(customer);
                }
                else
                {
                    return 15;
                }
            }
        }
        public abstract bool CanHandle(Customer customer);
        public abstract int CalcFee(Customer customer);
    }

    public class OldMan : BaseHandler
    {
        public override bool CanHandle(Customer customer)
        => (customer.Gender == true && customer.Age > 70);

        public override int CalcFee(Customer customer)
        => 2;        
    }
    public class OldWoman : BaseHandler {
        public override bool CanHandle(Customer customer)
            => (customer.Gender == false && customer.Age > 65);

        public override int CalcFee(Customer customer)
        => 3;
    }
    public class Child : BaseHandler {
        public override bool CanHandle(Customer customer)
            => customer.Age <=3;

        public override int CalcFee(Customer customer)
        => 1;
    
    }
    public class Standard : BaseHandler {
        public override bool CanHandle(Customer customer)
            => true;

        public override int CalcFee(Customer customer)
        => 15;
    }

    public class Customer
    {
        public bool Gender { get; set; }
        public int Age { get; set; }
    }
}
