using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
    class CustomerManager : ICustomerManager
    {
        public interface ICustomerManager : IRepository<Customer> { }
        static List<Customer> _customers = new List<Customer>()
        { 
            new Customer{Id=1,FullName="Taner Ürün",Address="İstanbul"},
            new Customer{Id=2,FullName="Haşim Ürün",Address="Gebze"},
            new Customer{Id=3,FullName="Engin Demirog",Address="Ankara"}
        
        };
        public List<Customer> List()
        {
            return _customers;
        }
        public Customer Find(int id)
        {
            return _customers.Find(x => x.Id == id);
        }

      

        public bool Remove(Customer customer)
        {
            return _customers.Remove(customer);
        }
    }
}
