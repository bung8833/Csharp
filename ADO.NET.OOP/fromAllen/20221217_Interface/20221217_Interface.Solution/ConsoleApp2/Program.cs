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
           
        }
    }
    public interface IPerson
    {
        string Name { get; set; }
        bool Gender { get; set; }
        void Create();
    }

    public class Animal
    {

    }

    public class Person:Animal { 
    
    }
   

    public class Member : IPerson
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public void Create()
        {
            throw new NotImplementedException();
        }
    }

    public class VIP : IPerson
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public void Create()
        {
            throw new NotImplementedException();
        }
    }
}
