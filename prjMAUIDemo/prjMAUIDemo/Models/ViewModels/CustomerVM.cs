using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMAUIDemo.Models.ViewModels
{
    public class CustomerVM
    {
        int _position = 0;

        List<Customer> _customers = new List<Customer>();

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public Customer CurrentCustomer
        {
            get { return _customers[_position]; }
            set { _customers[_position] = value; }
        }

        public CustomerVM()
        {
            LoadData();
        }

        private void LoadData()
        {
            _customers.Add(new Customer() { Id = 1, Name = "Richard", Phone = "0957930281", Email = "beam7294@gmail.com", Address = "Kaohsiung" });
            _customers.Add(new Customer() { Id = 2, Name = "Flora", Phone = "0932883423", Email = "florawhite@gmail.com", Address = "Pingtung" });
            _customers.Add(new Customer() { Id = 3, Name = "Simon", Phone = "0963875183", Email = "simon0518@gmail.com", Address = "Taipei" });
        }

        public void MoveTo(int to)
        {
            _position = to;
        }

        public void MoveFirst()
        {
            _position = 0;
        }

        public void MovePrevious()
        {
            _position--;

            if (_position < 0)
            {
                _position = 0;
            }
        }

        public void MoveNext()
        {
            _position++;

            if (_position > _customers.Count - 1)
            {
                _position = _customers.Count - 1;
            }
        }

        public void MoveLast()
        {
            _position = _customers.Count - 1;
        }

        public Customer QueryByKeyword(string keyword)
        {
            foreach (var customer in Customers)
            {
                if (customer.Name.Contains(keyword)
                 || customer.Phone.Contains(keyword)
                 || customer.Email.Contains(keyword)
                 || customer.Address.Contains(keyword))
                {
                    _position = Customers.IndexOf(customer);
                    return customer;
                }
            }

            return null;
        }
    }
}
