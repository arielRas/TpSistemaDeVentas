using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDao
    {
        private readonly CityDao _cityDao = new CityDao();
        private readonly CustomerTypeDao _typeDao = new CustomerTypeDao();
        private readonly CustomerIdentifierTypeDao _identifierDao = new CustomerIdentifierTypeDao();

        public Customer GetCustomerByIdNumber(Int64 idNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                SELECT 
	                ID_CUSTOMER, CT.[DESCRIPTION], IT.[DESCRIPTION], C.[NAME], C.LAST_NAME, C.GENDER,
	                C.EMAIL, C.PHONE, C.BIRTH_DATE, S.[NAME],CY.[NAME], C.STREET, C.NUMBER
                FROM CUSTOMER AS C
                JOIN CUSTOMER_TYPE AS CT
	                ON C.ID_CUSTOMER_TYPE = CT.ID_CUSTOMER_TYPE
                JOIN IDENTIFIER_TYPE AS IT
	                ON C.ID_IDENTIFIER_TYPE = IT.ID_IDENTIFIER_TYPE
                JOIN CITY AS CY
	                ON C.ID_CITY = CY.ID_CITY
                JOIN [STATE] AS S
	                ON CY.ID_STATE = S.ID_STATE
                WHERE IDENTIFIER_NUMBER = @idNumber";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idNumber", idNumber);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var customer = new Customer
                                {
                                    IdCustomer = reader.GetGuid(0),
                                    CustomerType = reader.GetString(1),
                                    IdType = reader.GetString(2),
                                    IdNumber = reader.GetInt64(3),
                                    Name = reader.GetString(4),
                                    LastName = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    Gender = reader.GetString(6),
                                    Email = reader.GetString(7),
                                    Phone = reader.GetString(8),
                                    BirthDate = Convert.ToDateTime(reader.GetValue(9)),
                                    State = reader.GetString(10),
                                    City = reader.GetString(11),
                                    Street = reader.GetString(12),
                                    Number = reader.GetInt32(13)
                                };
                                return customer;
                            }
                            else
                                throw new Exception("El numero de identificacion que utilizó no pertenece a un cliente regitrado");
                        }
                    }
                }
            }
            catch { throw; }
        }

        public bool ExistCustomer(Int64 idNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT 1 FROM CUSTOMER WHERE IDENTIFIER_NUMBER = @idNumber";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idNumber", idNumber);

                        return command.ExecuteScalar() != DBNull.Value;
                    }
                }
            }
            catch { throw; }
        }

        public Guid AddCustomer(Customer customer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                INSERT INTO CUSTOMER VALUES(
                    DEFAULT, @idCustomerType, @idIdentifierType, @identifierNumber, @name, 
                    @lastName, @gender, @email, @phone, @birthdate, @idCity, @street, @number);
                SELECT SCOPE_IDENTITY();";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idCustomerType", _typeDao.GetIdByName(customer.CustomerType));
                    command.Parameters.AddWithValue("@idIdentifierType",_identifierDao.GetIdByName(customer.IdType));
                    command.Parameters.AddWithValue("@identifierNumber",customer.IdNumber);
                    command.Parameters.AddWithValue("@name",customer.Name);
                    command.Parameters.AddWithValue("@lastName",customer.LastName);
                    command.Parameters.AddWithValue("@gender",customer.Gender);
                    command.Parameters.AddWithValue("@email",customer.Email);
                    command.Parameters.AddWithValue("@phone",customer.Phone);
                    command.Parameters.AddWithValue("@birthdate",customer.BirthDate);
                    command.Parameters.AddWithValue("@idCity",_cityDao.GetIdCity(customer.City, customer.State));
                    command.Parameters.AddWithValue("@street",customer.Street);
                    command.Parameters.AddWithValue("@number",customer.Number);                    
                    var newId = command.ExecuteScalar();
                    return Guid.Parse(newId.ToString());
                }
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                UPDATE CUSTOMER SET,
                    ID_CUSTOMER_TYPE = @idCustomerType,
                    ID_IDENTIFIER_TYPE = @idIdentifierType,
                    IDENTIFIER_NUMBER  = @identifierNumber,
                    [NAME] = @name,
                    LAST_NAME = @lastName,
                    GENDER = @gender,
                    EMAIL = @email,
                    PHONE = @phone,
                    BIRTH_DATE = @birthdate,
                    ID_CITY = @idCity,
                    STREET = @street,
                    NUMBER = @number
                WHERE ID_CUSTOMER = @idCustomer";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idCustomer", customer.IdCustomer);
                    command.Parameters.AddWithValue("@idCustomerType", _typeDao.GetIdByName(customer.CustomerType));
                    command.Parameters.AddWithValue("@idIdentifierType", _identifierDao.GetIdByName(customer.IdType));
                    command.Parameters.AddWithValue("@identifierNumber", customer.IdNumber);
                    command.Parameters.AddWithValue("@name", customer.Name);
                    command.Parameters.AddWithValue("@lastName", customer.LastName);
                    command.Parameters.AddWithValue("@gender", customer.Gender);
                    command.Parameters.AddWithValue("@email", customer.Email);
                    command.Parameters.AddWithValue("@phone", customer.Phone);
                    command.Parameters.AddWithValue("@birthdate", customer.BirthDate);
                    command.Parameters.AddWithValue("@idCity", _cityDao.GetIdCity(customer.City, customer.State));
                    command.Parameters.AddWithValue("@street", customer.Street);
                    command.Parameters.AddWithValue("@number", customer.Number);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}