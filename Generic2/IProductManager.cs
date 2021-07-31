using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
  public  interface IProductManager
    {
        List<Product> List();
        Product Find(int id);
        bool Remove(Product product);
    }
}
