using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CityRepository:Connection
    {
        /// <summary>
        /// Metoda na naplnenie miest.
        /// </summary>
        /// <returns></returns>
        public DataSet FillDataSet()
        {
            
            DataSet ds = new DataSet();
            string sqlQuery = @"select * from city";
            try
            {
                using(SqlConnection connection = base.CreateConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    
                    adapter.Fill(ds, "City");
                    DataTable dt = ds.Tables["City"];                    
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }                
            return ds;
        }
        /// <summary>
        /// Metoda na získanie id mesta podla názvu mesta.
        /// </summary>
        /// <param name="city">nazov mesta</param>
        /// <returns></returns>
        public int GetCityID(string city)
        {
            int cislo = 0;
            string sqlGetClientId = @" select id from city where name = @city;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlGetClientId, connection))
                        {
                            sqlCmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
                            cislo = (int)sqlCmd.ExecuteScalar();
                            if (cislo >= 1)
                            {
                                return cislo;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return cislo;
        }
    }
}
