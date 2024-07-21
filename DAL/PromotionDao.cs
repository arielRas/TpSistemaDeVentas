using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PromotionDao
    {
        public List<Promotion> GetPromotionsByDate(DateTime date)
        {
            var promotions = new List<Promotion>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT * FROM PROMOTION WHERE [START_DATE] <= @date AND END_DATE >= @date";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@date", date);

                        using(var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {                                
                                Promotion promotion = null;

                                if (reader.GetInt32(4) == 1)
                                {
                                    promotion = new PromotionByProduct();
                                }
                                else
                                    promotion = new PromotionByQuantity();

                                promotion.IdPromotion = reader.GetGuid(0);
                                promotion.Description = reader.GetString(1);
                                promotion.StartDate = reader.GetDateTime(2);
                                promotion.EndDate = reader.GetDateTime(3);
                                promotion.DiscountPercentage = reader.GetInt32(5);
                                promotions.Add(promotion);
                            }

                            return promotions;
                        }
                    }
                }
            }
            catch { throw; }
        }

        public List<Item> GetPromotionQuantityDetail(Guid idPromotion)
        {
            var promotionDetail = new List<Item>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            var sqlQuery = "SELECT ID_PRODUCT, QUANTITY FROM PROMOTION_QUANTITY WHERE ID_PROMOTION = @idPromotion";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using(var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPromotion", idPromotion);

                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var detail = new Item();
                            detail._product.IdProduct = reader.GetInt32(0);
                            detail.Quantity = reader.GetInt32(1);
                            promotionDetail.Add(detail);
                        }
                        return promotionDetail;                        
                    }
                }
            }

        }

        public List<Product> GetPromotionProductDetail(Guid idPromotion)
        {
            var promotionDetail = new List<Product>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            var sqlQuery = "SELECT ID_PRODUCT FROM PROMOTION_PRODUCT WHERE ID_PROMOTION = @idPromotion";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPromotion", idPromotion);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var detail = new Product{IdProduct = reader.GetInt32(0)};

                            promotionDetail.Add(detail);
                        }
                        return promotionDetail;
                    }
                }
            }
        }
    }
}
