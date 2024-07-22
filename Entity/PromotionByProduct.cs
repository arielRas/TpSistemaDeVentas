using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PromotionByProduct : Promotion
    {
        public List<Product> ProductList { get; set; }

        public override IEnumerable<object> Products => ProductList.Cast<Product>();

        public override List<int> GetIdProductsInPromotion()
        {
            return ProductList.Select(P => P.IdProduct).ToList();
        }
    }
}
