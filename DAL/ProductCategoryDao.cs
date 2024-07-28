using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductCategoryDao
    {
        public int GetIdByName(string categoryName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT ID_CATEGORY FROM PRODUCT_CATEGORY WHERE [NAME] = @categoryName";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@categoryName", categoryName);

                    var idCategory = command.ExecuteScalar();

                    if (idCategory != DBNull.Value)
                    {
                        return Convert.ToInt32(idCategory);
                    }
                    else
                        throw new Exception("No se encuentra el id para el nombre ingresado");
                }
            }
        }

        public string GetNameById(int idCategory)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT [NAME] FROM PRODUCT_CATEGORY WHERE ID_CATEGORY = @idCategory";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idCategory", idCategory);

                    var categoryName = command.ExecuteScalar();

                    if (categoryName != DBNull.Value)
                    {
                        return categoryName.ToString();
                    }
                    else
                        throw new Exception("No se encuentra el nombre para el id ingresado");
                }
            }
        }

        public List<string> GetCategoryNames()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT [NAME] FROM PRODUCT_CATEGORY";

            var categoryNames = new List<string>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categoryNames.Add(reader.GetString(0));
                            }

                            return categoryNames;
                        }
                    }
                }
            }
            catch { throw; }
        }
    }
}
