using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Threading;

namespace DAL
{
    public class ProductDao
    {
        private readonly ProductBrandDao _brandDao = new ProductBrandDao();
        private readonly ProductCategoryDao _categoryDao = new ProductCategoryDao();

        public Product GetProductById(int idProduct)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                SELECT P.ID_PRODUCT,P.[NAME],PB.[NAME],PC.[NAME] 
                FROM [PRODUCT] AS P 
                JOIN PRODUCT_BRAND AS PB ON P.ID_BRAND = PB.ID_BRAND 
                JOIN PRODUCT_CATEGORY AS PC ON P.ID_CATEGORY = PC.ID_CATEGORY 
                WHERE P.ID_PRODUCT = @idProduct";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idProduct", idProduct);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var product = new Product
                                {
                                    IdProduct = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Brand = reader.GetString(2),
                                    Category = reader.GetString(3)
                                };

                                return product;
                            }
                            else
                                throw new Exception("El producto seleccionado no existe");

                        }
                    }
                }
            }
            catch { throw; }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                SELECT P.ID_PRODUCT,P.[NAME],PB.[NAME],PC.[NAME] 
                FROM [PRODUCT] AS P 
                JOIN PRODUCT_BRAND AS PB ON P.ID_BRAND = PB.ID_BRAND 
                JOIN PRODUCT_CATEGORY AS PC ON P.ID_CATEGORY = PC.ID_CATEGORY;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new Product
                                {
                                    IdProduct = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Brand = reader.GetString(2),
                                    Category = reader.GetString(3)
                                };

                                products.Add(product);
                            }

                            return products;
                        }
                    }

                }
            }
            catch { throw; }
        }
            
        public List<Product> GetProductsByCategory(string category)
        {
            var products = new List<Product>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                SELECT P.ID_PRODUCT,P.[NAME],PB.[NAME],PC.[NAME] 
                FROM [PRODUCT] AS P 
                JOIN PRODUCT_BRAND AS PB ON P.ID_BRAND = PB.ID_BRAND 
                JOIN PRODUCT_CATEGORY AS PC ON P.ID_CATEGORY = PC.ID_CATEGORY 
                WHERE PC.[NAME] = @category";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@category", category);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new Product
                                {
                                    IdProduct = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Brand = reader.GetString(2),
                                    Category = reader.GetString(3)
                                };

                                products.Add(product);
                            }

                            return products;
                        }
                    }
                }
            }
            catch { throw; }            
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            var products = new List<Product>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                SELECT P.ID_PRODUCT,P.[NAME],PB.[NAME],PC.[NAME] 
                FROM [PRODUCT] AS P 
                JOIN PRODUCT_BRAND AS PB ON P.ID_BRAND = PB.ID_BRAND 
                JOIN PRODUCT_CATEGORY AS PC ON P.ID_CATEGORY = PC.ID_CATEGORY 
                WHERE PB.[NAME] = @brand";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@brand", brand);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new Product
                                {
                                    IdProduct = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Brand = reader.GetString(2),
                                    Category = reader.GetString(3)
                                };

                                products.Add(product);
                            }

                            return products;
                        }
                    }
                }
            }
            catch { throw; }
        }

        public double GetPrice(int idProduct, DateTime date)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT dbo.FN_GET_PRICE(@idProduct, @date)";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idProduct", idProduct);

                        command.Parameters.AddWithValue("@date", date);

                        var price = command.ExecuteScalar();

                        if (price == DBNull.Value) throw new Exception("El precio del producto seleccionado no esta disponible");

                        return Convert.ToDouble(price);
                    }
                }
            }
            catch { throw; }
        }
    
        public void AddProduct(Product product)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "INSERT INTO [PRODUCT] VALUES(@name, @idBrand, @idCategory)";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using(var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@idBrand", _brandDao.GetIdByName(product.Brand));
                    command.Parameters.AddWithValue("@idCategory", _categoryDao.GetIdByName(product.Category));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
