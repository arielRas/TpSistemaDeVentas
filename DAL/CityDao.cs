using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class CityDao
    {
        public int GetIdCity(string city, string state)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyStoreDb"].ConnectionString;

            string sqlQuery = @"
                SELECT
	                ID_CITY
                FROM CITY AS C
                JOIN [STATE] AS S
	                ON C.ID_STATE = S.ID_STATE
                WHERE
	                C.[NAME] = @city AND
	                S.[NAME] = @state";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@city", city);
                        command.Parameters.AddWithValue("@state", state);
                        var idCity =  command.ExecuteScalar();

                        if (idCity != DBNull.Value)
                        {
                            return Convert.ToInt32(idCity);
                        }
                        else
                            throw new Exception("La ciudad no existe en el estado seleccionado");
                    }
                }
            }
            catch { throw; }
        }        
    }
}
