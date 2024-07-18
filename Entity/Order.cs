using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public Guid IdOrder { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryMethod { get; set; }
        public List<Product> Products { get; set; }
        public List<Promotion> Promotions { get; set; }        
    }
}
