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
    public class OrderPromotionDao
    {
        public void AddPromotionAtOrder(int idOrder, Guid idPromotion)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "INSERT INTO ORDER_PROMOTION VALUES(@idOrder, @idPromotion)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idOrder", idOrder);
                    command.Parameters.AddWithValue("@idPromotion", idPromotion);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
