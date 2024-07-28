using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductBusiness
    {
        public readonly ProductDao productDao = new ProductDao();

        private double GetCurrentPrice(int idProduct)
        {
            try
            {
                return productDao.GetPrice(idProduct, DateTime.Now);
            }
            catch { throw; }            
        }

        public Product GetProductById(int idProduct)
        {
            try
            {
                Product product = productDao.GetProductById(idProduct);
                product.Price = GetCurrentPrice(product.IdProduct);
                return product;
            }
            catch { throw; }            
        }

        public List<Product> GetAllProducts() 
        {
            try
            {
                List<Product> products = productDao.GetAllProducts();
                products.ForEach(p => p.Price = GetCurrentPrice(p.IdProduct));
                return products;
            }
            catch { throw; }            
        }

        public List<Product> GetAllProducts(string category, string brand, string name)
        {
            try
            {
                List<Product> products = productDao.GetAllProducts(category, brand, name);
                products.ForEach(p => p.Price = GetCurrentPrice(p.IdProduct));
                return products;
            }
            catch { throw; }
        }
    }
}
