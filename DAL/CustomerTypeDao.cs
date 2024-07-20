using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class CustomerTypeDao
    {
        public int GetIdByName(string customerType)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT ID_CUSTOMER_TYPE FROM CUSTOMER_TYPE WHERE [DESCRIPTION] = @customerType";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@customerType", customerType);

                        var idType = command.ExecuteScalar();

                        if(idType == DBNull.Value) throw new Exception("El tipo de cliente ingresado no existe");

                        return Convert.ToInt32(idType);
                    }
                }
            }
            catch { throw; }
        }
    }
}