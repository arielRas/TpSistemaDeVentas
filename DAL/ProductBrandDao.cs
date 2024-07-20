using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ProductBrandDao
    {
        public int GetIdByName(string brandName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT ID_BRAND FROM PRODUCT_BRAND WHERE [NAME] = @brandName";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@brandName", brandName);

                    var idBrand = command.ExecuteScalar();

                    if (idBrand != DBNull.Value)
                    {
                        return Convert.ToInt32(idBrand);
                    }
                    else 
                        throw new Exception("No se encuentra el id para el nombre ingresado");
                }
            }
        }

        public string GetNameById(int idBrand)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT [NAME] FROM PRODUCT_BRAND WHERE ID_BRAND = @idBrand";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idBrand", idBrand);

                    var brandName = command.ExecuteScalar();

                    if (brandName != DBNull.Value)
                    {
                        return brandName.ToString();
                    }
                    else
                        throw new Exception("No se encuentra el nombre para el id ingresado");
                }
            }
        }
    }
}
