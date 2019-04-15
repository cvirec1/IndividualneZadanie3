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
using sinkien.IBAN4Net;

namespace Data.Repositories
{
    public class AccountRepository : Connection
    {
        public int _accountID;
        public DataSet FillDataSet()
        {
            string sqlQuery = @"select a.id,c.id as clientID,FirstName,LastName,CreationDate,IBAN,c.IdNumber from Account as a join Client as c on a.Id_Client = c.id ";
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

        public DataSet FillSourceDataSet(int id)
        {
            string sqlQuery = @"select id,iban,Amount from Account where id = @id";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public DataSet FillDestinationDataSet(int id)
        {
            string sqlQuery = @"select a.id,iban,CONCAT(FirstName,' ',LastName) as ClientName from Account as a
join Client as c on a.Id_Client=c.id where a.id!= @id and (a.ExpireDate is null)";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public DataSet FilterDataSet(string name, string surname, string number)
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

        public bool InsertAccount(Account account)
        {
            string sqlInsertAccount = @" insert into Account (Id_Client,Id_Bank,Amount,IBAN,OverFlowLimit)
  output inserted.id values (@client,@bank,@amount,@iban,@limit);";                        
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
                        {
                            sqlCmd.Parameters.Add("@client", SqlDbType.Int).Value = account.ID_Client;
                            sqlCmd.Parameters.Add("@bank", SqlDbType.Int).Value = account.ID_Bank;
                            sqlCmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = account.Amount;
                            sqlCmd.Parameters.Add("@iban", SqlDbType.NVarChar).Value = account.IBAN;
                            sqlCmd.Parameters.Add("@limit", SqlDbType.Int).Value = account.OverFlowLimit;
                            _accountID = (int)sqlCmd.ExecuteScalar();
                            if (_accountID > 0)
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

        public string GetAccountAmount(int id)
        {
            string amount;
            string sqlInsertAccount = @" select Amount from Account where id = @id;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;                            
                            amount = sqlCmd.ExecuteScalar().ToString();
                            if (amount.Length > 0)
                            {
                                return amount;
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
            return amount;
        }

        public bool UpdateAccount(Account account, int accountID)
        {
            string sqlInsertAccount = @" update Account set Amount=@amount,OverFlowLimit=@limit
  where id = @id";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
                        {
                            sqlCmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = account.Amount;                          
                            sqlCmd.Parameters.Add("@limit", SqlDbType.Int).Value = account.OverFlowLimit;
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = account.ID;
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

        public bool UpdateAccountAmount(int id)
        {
            string sqlInsertAccount = @" update Account
set Amount = Amount + (
select top 1 case
when t.TransactionType = 'W' then t.Amount * (-1)
else t.Amount
end
from [Transaction] as t
JOIN AccountTransaction as act
ON t.Id = act.Id_Transaction
WHERE act.Id_Destination_Account = @id OR act.Id_Account = @id
ORDER BY t.Id desc)
where id = @id";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
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

        public bool UpdateSourceAccountAmount(int id)
        {
            string sqlInsertAccount = @" update Account
set Amount = Amount - (
select top 1 case
when t.TransactionType = 'T' then t.Amount
end
from [Transaction] as t
JOIN AccountTransaction as act
ON t.Id = act.Id_Transaction
WHERE act.Id_Destination_Account = @id OR act.Id_Account = @id
ORDER BY t.Id desc)
where id = @id";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
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

        public bool UpdateDestinationAccountAmount(int id)
        {
            string sqlInsertAccount = @" update Account
set Amount = Amount + (
select top 1 case
when t.TransactionType = 'T' then t.Amount
end
from [Transaction] as t
JOIN AccountTransaction as act
ON t.Id = act.Id_Transaction
WHERE act.Id_Destination_Account = @id OR act.Id_Account = @id
ORDER BY t.Id desc)
where id = @id";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertAccount, connection))
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
        public void IsValidIBan(string iban)
        {
            try
            {
                IbanUtils.Validate(iban);
            }
            catch (IbanFormatException iex)
            {
                Debug.WriteLine(iex.Message);
            }
        }

        public List<string> GetAccountData(int id)
        {
            List<string> list = new List<string>();
            string sqlGetAccountData = @" select IBAN,Amount,OverFlowLimit from Account where id = @id;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlGetAccountData, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                            try
                            {
                                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        list.Add(reader.GetString(0));
                                        list.Add(reader.GetDecimal(1).ToString());
                                        list.Add(reader.GetDecimal(2).ToString());                                        
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
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return list;
        }

        public string GenerateIBAN()
        {
            Random random = new Random();
            
            Iban iban = new IbanBuilder().CountryCode(CountryCode.GetCountryCode("SK"))
                .BankCode("1111")
                .AccountNumberPrefix("666666")
                .AccountNumber(random.Next(1000000000, Int32.MaxValue).ToString())
                .Build();
            IsValidIBan(iban.ToString());
            return iban.ToString();                          
        }
    }
}

