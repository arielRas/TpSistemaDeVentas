using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBusiness
    {
        private readonly CustomerDao _customerDao = new CustomerDao();

        public Customer GetCustomerByIdNumber(Int64 idNumber)
        {
            try
            {
                if (!ExistCustomer(idNumber)) throw new Exception("El Numero de identificacion ingresado no existe");
                return _customerDao.GetCustomerByIdNumber(idNumber);
            }
            catch { throw; }            
        }

        public Customer AddCustomer(Customer customer)
        {
            try
            {
                if (ExistCustomer(customer.Number)) throw new Exception("El cliente que desea ingresar ya se encuentra registrado");
                customer.IdCustomer = _customerDao.AddCustomer(customer);
                return customer;                
            }
            catch { throw; }
        }

        private bool ExistCustomer(Int64 idNumber)
        {
            try
            {
                return _customerDao.ExistCustomer(idNumber);
            }
            catch { throw; }
        }
    }
}
