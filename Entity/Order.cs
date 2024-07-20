using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime Date { get; set; }
        public DeliveryMethod _DeliveryMethod{ get; set; }
        public List<OrderItem> Items{ get; set; }
        public List<Promotion> Promotions { get; set; }        
    }
}
