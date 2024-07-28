using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Business
{
    public class ProductBrandBusiness
    {
        private readonly ProductBrandDao _brandDao = new ProductBrandDao();

        public List<string> GetBrandNames()
        {
            try
            {
                return _brandDao.GetBrandNames();
            }
            catch { throw; }
        }
    }
}
