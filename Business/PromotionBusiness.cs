using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PromotionBusiness
    {
        private readonly PromotionDao _promotionDao = new PromotionDao();
        private readonly ProductDao _productDao = new ProductDao();


        public List<Promotion> GetCurrentPromotions()
        {
            try
            {
                List<Promotion> promotion = _promotionDao.GetPromotionsByDate(DateTime.Now);

                return GetRelationships(promotion);

            }
            catch { throw; }
        }
        

        private Product GetProductById(int idProduct)
        {
            try
            {
                return _productDao.GetProductById(idProduct);
            }
            catch { throw; }
        }


        private List<Promotion> GetPromotionDetail(List<Promotion> promotions)
        {
            try
            {
                foreach (var promotion in promotions)
                {
                    if (promotion is PromotionByProduct)
                    {
                        (promotion as PromotionByProduct).Products = _promotionDao.GetPromotionProductDetail(promotion.IdPromotion);
                    }
                    else
                        (promotion as PromotionByQuantity).Products = _promotionDao.GetPromotionQuantityDetail(promotion.IdPromotion);
                }
                return promotions;
            }
            catch { throw; }
        }


        private List<Promotion> GetRelationships(List<Promotion> promotions)
        {
            try
            {
                promotions = GetPromotionDetail(promotions);

                foreach (var promotion in promotions)
                {
                    if (promotion is PromotionByProduct)
                    {
                        (promotion as PromotionByProduct).Products.ForEach(P => P = GetProductById(P.IdProduct));
                    }
                    else
                        (promotion as PromotionByQuantity).Products.ForEach(P => P._product = GetProductById(P._product.IdProduct));
                }
                return promotions;
            }
            catch { throw; }
        }
    }
}
