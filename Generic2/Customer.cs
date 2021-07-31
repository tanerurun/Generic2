using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
