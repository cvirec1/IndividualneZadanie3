using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
    public class AccountRepository:Connection
    {
        public DataSet FillDataSet()
        {
            string sqlQuery = @"select a.id,FirstName,LastName,CreationDate,IBAN,c.IdNumber from Account as a join Client as c on a.Id_Client = c.id ";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    adapter.Fill(ds, "Account");
                    DataTable dt = ds.Tables["Account"];
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }


            return ds;
        }

        public DataSet FilterDataSet(string name, string surname,string number)
        {
            string sqlQuery = @"select a.id,FirstName,LastName,CreationDate,IBAN,c.IdNumber from Account as a join Client as c on a.Id_Client = c.id 
  where (firstname like @name and lastname like @surname) and c.idnumber like @idnumber";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        sqlCmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = $"%{name}%";
                        sqlCmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = $"%{surname}%";
                        sqlCmd.Parameters.Add("@idnumber", SqlDbType.NVarChar).Value = $"%{number}%";
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                        adapter.Fill(ds, "Account");
                        DataTable dt = ds.Tables["Account"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        
    }
}
