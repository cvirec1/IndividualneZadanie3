
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
        int _cardID;
        int _accountID;
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

        public bool InsertCard(int limit,int id)        
        {
            string sqlInsertAccount = @" insert into Card (number,dailyLimit,id_account,pin)
  output inserted.id values (@number,@dailylimit,@idAccount,@pin);";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
                        {
                            sqlCmd.Parameters.Add("@number", SqlDbType.Int).Value = GenerateCardNumber();
                            sqlCmd.Parameters.Add("@dailylimit", SqlDbType.Int).Value = limit;
                            sqlCmd.Parameters.Add("@idAccount", SqlDbType.Int).Value = id;
                            sqlCmd.Parameters.Add("@pin", SqlDbType.Char).Value = GenerateCardPIN();
                           
                            _cardID = (int)sqlCmd.ExecuteScalar();
                            if (_cardID > 0)
                            {
                                return true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool CancelCard(int id)
        {
            string sqlCancelCard = @" update card set expiredate = getdate() where id = @id;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlCancelCard, connection))
                        {                            
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;                            
                            if (sqlCmd.ExecuteNonQuery() > 0)
                            {
                                return true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool ControlCard(int id,int pin)
        {
            string sqlCheckCard = @" select COUNT(*) from [Card] where id = @id and pin =@pin and ExpireDate>GETDATE();";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlCheckCard, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            sqlCmd.Parameters.Add("@pin", SqlDbType.Int).Value = pin;
                            if ((int)sqlCmd.ExecuteScalar() == 1)
                            {
                                return true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public int GetAccountID(int id)
        {
            string sqlCheckCard = @" select Id_Account from Card where id =@id;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlCheckCard, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            return (int)sqlCmd.ExecuteScalar();
                            
                            
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public int GenerateCardNumber()
        {
            Random random = new Random();            
            return random.Next(100000000,int.MaxValue);
        }

        public string GenerateCardPIN()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }
    }
}
