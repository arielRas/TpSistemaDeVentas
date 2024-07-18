using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PromotionByQuantity : Promotion
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
    }
}
