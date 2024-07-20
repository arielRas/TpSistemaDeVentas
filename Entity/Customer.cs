using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer : Person
    {
		public Guid IdCustomer { get; set; }
        public string IdType { get; set; }
        public Int64 IdNumber { get; set; }
		public string CustomerType { get; set; }
    }
}