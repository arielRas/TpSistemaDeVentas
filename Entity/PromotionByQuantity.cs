using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PromotionByQuantity : Promotion
    {
        public List<Item> Products { get; set; }
    }
}
