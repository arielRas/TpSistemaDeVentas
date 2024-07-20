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
    public class OrderDao
    {
        public int AddOrder(Guid idCustomer, Guid idEmployee, DateTime date, int idDeliveryMehod)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "INSERT INTO [ORDER] VALUES(@date, @idCustomer, @idEmployee,@idDeliveryMethod); SELECT SCOPE_IDENTITY();";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection)) 
                    {
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("idCustomer", idCustomer);
                        command.Parameters.AddWithValue("@idEmployee", idEmployee);
                        command.Parameters.AddWithValue("@idDeliveryMethod", idDeliveryMehod);
                        var newId = command.ExecuteScalar();
                        return Convert.ToInt32(newId);
                    }
                }
            }
            catch { throw; }
        }
    }
}
