using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
  public  interface IRepository<T> where T:class,IEntity
    {
        List<T> List();
        T Find(int id);
        bool Remove(T entity);
    }
    
}
