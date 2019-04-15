using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data.Repositories
{
    public class Connection
    {
        /// <summary>
        /// Metoda na trudted vytvorenie connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection CreateConnection()
        {
            string connString = @"Server = VALJASEK\SQL2017; Database = BankSystem; Trusted_Connection = True;";
            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }
    }
}
