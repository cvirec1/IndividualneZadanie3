using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Data.Repositories
{
    public class TransactionRepository:Connection
    {
        public DataSet FillAccountDataSet(int id)
        {
            string sqlQuery = @"select Id_Transaction,Id_Account as odosielatel,Id_Destination_Account as prijemca,tr.Amount,tr.CreationDate,tr.ExecuteDate,tr.KS,tr.SS,tr.VS
  from AccountTransaction as atr
  join [Transaction] as tr on atr.Id_Transaction=tr.Id
  where Id_Account = @id";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                            adapter.Fill(ds, "Transaction");
                            DataTable dt = ds.Tables["Transaction"];
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
            return ds;
        }
        public DataSet FillDataSet()
        {
            string sqlQuery = @"select Id_Transaction,Id_Account as odosielatel,Id_Destination_Account as prijemca,tr.Amount,tr.CreationDate,tr.ExecuteDate,tr.KS,tr.SS,tr.VS
  from AccountTransaction as atr
  join [Transaction] as tr on atr.Id_Transaction=tr.Id";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                        {                            
                            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                            adapter.Fill(ds, "Transaction");
                            DataTable dt = ds.Tables["Transaction"];
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
            return ds;
        }

        public int GetAccountID(int id)
        {
            int cislo = 0;
            string sqlGetClientId = @" select id from Account where Id_Client = @id;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlGetClientId, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
