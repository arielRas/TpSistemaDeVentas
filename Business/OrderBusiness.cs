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
        private readonly OrderPromotionDao _orderPromDao = new OrderPromotionDao();
        private readonly PromotionDao _promotionDao = new PromotionDao();
        private readonly ProductDao _productDao = new ProductDao();
               

        //METODO PARA AGREGAR UNA NUEVA ORDEN A LA BASE DE DATOS
        public void AddOrder(Order order, Guid idCustomer, Guid idEmployee)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    if (IsProductInStock(order.Items))
                    {
                        order.Date = DateTime.Now;

                        order.IdOrder = _orderDao.AddOrder(idCustomer, idEmployee, order.Date, (int)order._DeliveryMethod);

                        AddOrderItems(order);

                        UpdateProductStock(order.Items);

                        if (order.Promotions.Count() > 0) AddPromotionAtOrder(order.IdOrder, order.Promotions);

                        trx.Complete();
                    } 
                }                
            }
            catch { throw; }                       
        }


        private void AddOrderItems(Order order)
        {
            try
            {
                order.Items.ForEach(I => _itemDao.AddOrderItem(order.IdOrder, I));
            }
            catch { throw; }
        }


        private void AddPromotionAtOrder(int idOrder, List<Promotion> promotions)
        {
            try
            {
                promotions.ForEach(P => _orderPromDao.AddPromotionAtOrder(idOrder, P.IdPromotion));
            }
            catch { throw; }
        }
        
        private bool IsProductInStock(List<Item> orderItems)
        {
            try
            {
                foreach(var item in orderItems)
                {
                    if (!_productDao.IsInStock(item._product.IdProduct, item.Quantity))
                    {
                        throw new Exception($"No hay suficiente stock del producto codigo: {item._product.IdProduct}");
                    }
                }
                return true;
            }
            catch { throw; }
        }

        private void UpdateProductStock(List<Item> orderItems)
        {
            try
            {
                orderItems.ForEach(O => _productDao.UpdateStockById(O._product.IdProduct, O.Quantity));
            }
            catch { throw; }
        }
    }
}