using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PromotionByQuantity : Promotion
    {
        public List<Item> ProductList {  get; set; }

        public override IEnumerable<object> Products => ProductList.Cast<Item>();

        public override List<int> GetIdProductsInPromotion()
        {
            return ProductList.Select(P => P._product.IdProduct).ToList();
        }
    }
}
