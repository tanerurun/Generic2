using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
   public interface ICustomerManager 
    {
        List<Customer> List();
        Customer Find(int id);
        bool Remove(Customer customer);
    }
}
