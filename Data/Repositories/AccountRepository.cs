﻿using System;
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

        
        public string GenerateIBAN()
        {
            Iban iban = new IbanBuilder().CountryCode(CountryCode.GetCountryCode("SK"))
                .BankCode("1100")
                .AccountNumberPrefix("000000")
                .AccountNumber("3650018070")
                .Build();
            IsValidIBan(iban.ToString());
            return iban.ToString();                          
        }
    }
}
