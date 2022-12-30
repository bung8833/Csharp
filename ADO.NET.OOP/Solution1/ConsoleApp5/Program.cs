using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Gender=true, Age=2 };
            BaseHandler handler = InitHandlers();
            int fee = handler.ProcessRequest(customer);
            Console.WriteLine($"車資：{fee}");

            Console.ReadKey();
        }

        static BaseHandler InitHandlers()
        {
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

    
    public abstract class BaseHandler // 抽象成員要在抽象class中
    {
        public BaseHandler Successor { get; set; } // 繼承者
        
        public int ProcessRequest(Customer customer)
        {
            if (CanHandle(customer))
            {
                return CalcFee(customer);
            }
            else
            {
                if (Successor != null)
                {
                    return Successor.ProcessRequest(customer);
                }
                else
                {
                    return 15;
                }
            }
                
        }

        // 父類別有 子類別要實作
        public abstract bool CanHandle(Customer customer);

        public abstract int CalcFee(Customer customer);
    }



    public class OldMan : BaseHandler
    {
        public override int CalcFee(Customer customer)
        => 2;

        public override bool CanHandle(Customer customer)
        {
            return (customer.Gender == true && customer.Age > 70);
        }
    }

    
    
    public class OldWoman : BaseHandler
    {
        public override int CalcFee(Customer customer)
        => 3;

        public override bool CanHandle(Customer customer)
        {
            return (customer.Gender == false && customer.Age > 65);
        }
    }

    
    
    public class Child : BaseHandler
    {
        public override int CalcFee(Customer customer)
        => 1;

        public override bool CanHandle(Customer customer)
        {
            return (customer.Age <= 3); 
        }
    }

    
    
    public class Standard : BaseHandler
    {
        public override int CalcFee(Customer customer)
        => 15;

        public override bool CanHandle(Customer customer)
        {
            return true;
        }
    }




    public class Customer
    {
        public bool Gender { get; set; }
        public int Age { get; set; }
    }


}
