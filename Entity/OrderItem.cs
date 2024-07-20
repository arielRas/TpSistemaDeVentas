using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderItem
    {
        public Product _product { get; set; }
        public int Quantity { get; set; }
    }
}