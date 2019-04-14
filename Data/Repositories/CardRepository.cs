
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Data.Repositories
{
    public class CardRepository:Connection
    {

        public DataSet FillDataSet(int id)
        {
            string sqlQuery = @"select c.[Id]
      ,[Number]
      ,[DailyLimit]
      ,[Id_Account]
      ,c.[ExpireDate]
      ,[Pin] from Card as c
  join Account as a on c.Id_Account=a.Id
   where Id_Client = @id";
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
                            adapter.Fill(ds, "Card");
                            DataTable dt = ds.Tables["Card"];
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

        public DataSet ActiveCard(int id)
        {
            string sqlQuery = @"select c.[Id]
      ,[Number]
      ,[DailyLimit]
      ,[Id_Account]
      ,c.[ExpireDate]
      ,[Pin] from Card as c
  join Account as a on c.Id_Account=a.Id
   where Id_Client = @id and (c.[ExpireDate] > getdate())";
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
                            adapter.Fill(ds, "Card");
                            DataTable dt = ds.Tables["Card"];
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
        public DataSet ExpiredCard(int id)
        {
            string sqlQuery = @"select c.[Id]
      ,[Number]
      ,[DailyLimit]
      ,[Id_Account]
      ,c.[ExpireDate]
      ,[Pin] from Card as c
  join Account as a on c.Id_Account=a.Id
   where Id_Client = @id and (c.[ExpireDate] < getdate())";
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
                            adapter.Fill(ds, "Card");
                            DataTable dt = ds.Tables["Card"];
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
    }
}
