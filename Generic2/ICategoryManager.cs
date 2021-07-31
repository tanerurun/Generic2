using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
  public  interface ICategoryManager 
    {
        List<Category> List();
        Category Find(int id);
        bool Remove(Category category);
    }
}
