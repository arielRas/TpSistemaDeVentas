using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderItemDao
    {
        public void AddOrderItem(int idOrder, OrderItem item)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "INSERT INTO ORDER_DETAIL VALUES (@idOrder, @idProduct, @quantity)";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idOrder", idOrder);
                        command.Parameters.AddWithValue("@idProduct", item._product.IdProduct);
                        command.Parameters.AddWithValue("@quantity", item.Quantity);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch { throw; }
        }
    }
}
