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

        /// <summary>
        /// Metóda ktorá vráti zoznam učtov do datagrdiview v okne frmAccounts.
        /// </summary>
        /// <returns>Zoznam účtov klientov.</returns>
        public DataSet FillDataSet()
        {
            string sqlQuery = @"select a.id,c.id as clientID,FirstName,LastName,CreationDate,IBAN,c.IdNumber from Account as a join Client as c on a.Id_Client = c.id 
  join Bank as b on a.Id_Bank = b.Id
where a.Id_Bank =7 and ((expiredate is null) or (expiredate>getdate()))";
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
        /// <summary>
        /// Metóda na naplnenie zdrojového gridu pri výbere peňazí z účtu v Bank systém a ATM.
        /// </summary>
        /// <param name="id">id z tabuľky Account</param>
        /// <returns>DataSet</returns>
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
        /// <summary>
        /// Metóda na naplnenie cieľového gridu pri vklade peňazí na účet.
        /// </summary>
        /// <param name="id">id z tabuľky Account</param>
        /// <returns>DataSet</returns>
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
        /// <summary>
        /// Metóda na filtrovanie v okne frmAccounts na základe mena priezviska a idNumber
        /// </summary>
        /// <param name="name">meno klienta</param>
        /// <param name="surname">priezvisko klienta</param>
        /// <param name="number">idnumber klienta</param>
        /// <returns>DataSet</returns>
        public DataSet FilterDataSet(string name, string surname, string number)
        {
            string sqlQuery = @"select a.id,c.id as clientID,FirstName,LastName,CreationDate,IBAN,c.IdNumber from Account as a join Client as c on a.Id_Client = c.id 
  join Bank as b on a.Id_Bank = b.Id
where (a.Id_Bank =7 and ((expiredate is null) or (expiredate>getdate())))
and ((firstname like @name and lastname like @surname) and c.idnumber like @idnumber)";
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
        /// <summary>
        /// Prehľad koľko peňazi je vložených v banke.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet ViewBankData()
        {
            string sqlQuery = @"select b.Name,sum(Amount) from Account as a
  join Bank as b on a.Id_Bank=b.Id
  where b.Id=7
  group by b.Id,b.Name";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {                        
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
        /// <summary>
        /// Prehľad top 10 účtov v banke podľa najvyššej sumy na účte.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet ViewTopAccount()
        {
            string sqlQuery = @"select top 10 c.FirstName,c.LastName,Amount,IBAN from Account as a
  join Client as c on a.Id_Client=c.id
  where Id_Bank = 7 and ((expiredate is null) or (expiredate>getdate()))
  order by Amount desc";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
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
        /// <summary>
        /// Prehľad počtu úštov a banke.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet ViewAccountCount()
        {
            string sqlQuery = @"select b.Name,count(*) as AccountCount from Account as a
  join Bank as b on a.Id_Bank=b.Id
  where Id_Bank = 7
  group by b.Name";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
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
        /// <summary>
        /// Vloženie účtu do databázy.
        /// </summary>
        /// <param name="account">Inštancia account</param>
        /// <returns>bool</returns>
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
        /// <summary>
        /// Metóda pre vrátenie sumy klienta na jeho účte.
        /// </summary>
        /// <param name="id">id účtu klienta</param>
        /// <returns>suma vratená v string formáte</returns>
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
        /// <summary>
        /// Update účtu klienta kde je možné upraviť 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public bool UpdateAccount(Account account, int accountID)
        {
            string sqlUpdateAccount = @" update Account set Amount=@amount,OverFlowLimit=@limit
  where id = @id";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlUpdateAccount, connection))
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
        /// <summary>
        /// Metoda na nastavenie účtu expiredate
        /// </summary>
        /// <param name="accountID">accoun id</param>
        /// <returns>bool</returns>
        public bool CloseAccount(int accountID)
        {
            string sqlUpdateAccount = @" update Account set expiredate=getdate() where id = @id";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlUpdateAccount, connection))
                        {
                           
                            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = accountID;
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
        /// <summary>
        /// Metoda na odčítanie prípadne pričítanie sumy podľa typu transakcie ktorú klient vykonal. W-witdraw D+deposit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoda na odcitanie sumy pri transakcii z uctu na ucet zo zdrojového účtu.
        /// </summary>
        /// <param name="id">id account</param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoda na pričítanie sumy pri transakcii z uctu na ucet do cieľového účtu.
        /// </summary>
        /// <param name="id">id account</param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoda na validáciu účtu.
        /// </summary>
        /// <param name="iban"></param>
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
        /// <summary>
        /// Metoda ktora mi vraciaList s údajmi o účte.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metóda na generovanie IBAN.
        /// </summary>
        /// <returns></returns>
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

