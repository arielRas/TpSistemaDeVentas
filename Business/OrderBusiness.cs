using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class OrderBusiness
    {
        private readonly OrderDao _orderDao = new OrderDao();
        private readonly OrderItemDao _itemDao = new OrderItemDao();

        public void AddOrder(Order order, Guid idCustomer, Guid idEmployee)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    DateTime date = DateTime.Now;

                    order.IdOrder = _orderDao.AddOrder(idCustomer, idEmployee, date, (int)order._DeliveryMethod);

                    order.Items.ForEach(I => _itemDao.AddOrderItem(order.IdOrder, I));

                    trx.Complete();
                }                
            }
            catch { throw; }                       
        }
    }
}
