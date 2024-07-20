using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class CustomerIdentifierTypeDao
    {
        public int GetIdByName(string identifierType)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = "SELECT ID_IDENTIFIER_TYPE FROM IDENTIFIER_TYPE WHERE [DESCRIPTION] = @identifierType";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@identifierType", identifierType);

                        var idType = command.ExecuteScalar();

                        if (idType == DBNull.Value) throw new Exception("El tipo de identificacion ingresado no existe");

                        return Convert.ToInt32(idType);
                    }
                }
            }
            catch { throw; }
        }
    }
}
