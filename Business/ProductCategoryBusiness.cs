using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductCategoryBusiness
    {
        private readonly ProductCategoryDao _categoryDao = new ProductCategoryDao();

        public List<string> GetCategoryNames()
        {
            try
            {
                return _categoryDao.GetCategoryNames();
            }
            catch { throw; }
        }
    }
}