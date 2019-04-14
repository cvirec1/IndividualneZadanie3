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
    }
}
