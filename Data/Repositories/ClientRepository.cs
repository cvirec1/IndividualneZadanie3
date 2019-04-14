using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
    public class ClientRepository:Connection
    {
        public bool FindClient(string id)
        {
            string sqlFindClient = @" select count(*) from client where idnumber = @idnumber;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlFindClient, connection))
                        {
                            sqlCmd.Parameters.Add("@idnumber", SqlDbType.NVarChar).Value = id;
                            int cislo = (int)sqlCmd.ExecuteScalar();
                            if (cislo == 1)
                            {
                                return true;
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
            return false;
        }

        public int GetClientID(string id)
        {
            int cislo = 0;
            string sqlGetClientId = @" select id from client where idnumber = @idnumber;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlGetClientId, connection))
                        {
                            sqlCmd.Parameters.Add("@idnumber", SqlDbType.NVarChar).Value = id;
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

        public bool UpdateClient(int id ,string name,string surname, string adress, string city,string postalcode, string idnumber)
        {
            string sqlUpdateClient = @" update client set firstname = @name,lastname = @surname,adress=@adress, idnumber=@idnumber, id_city=@city where id = @id;";
            string sqlSelectCity = @" select id from city where name = @cityname;";
            int cityId;
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlSelectCity, connection))
                        {
                            sqlCmd.Parameters.Add("@cityname", SqlDbType.Int).Value = city;
                            cityId = (int)sqlCmd.ExecuteScalar();                            
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlUpdateClient, connection))
                        {
                            sqlCmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                            sqlCmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = surname;
                            sqlCmd.Parameters.Add("@idnumber", SqlDbType.NVarChar).Value = idnumber;
                            sqlCmd.Parameters.Add("@adress", SqlDbType.NVarChar).Value = adress;
                            sqlCmd.Parameters.Add("@city", SqlDbType.Int).Value = cityId;
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

        public bool InsertClient(Client client)
        {
            string sqlInsertClient = @" insert into client (firstname,lastname,Adress,Id_City,IdNumber) output inserted.id values  (@name,@surname,@adress,@city,@idnumber);";
            string sqlSelectCity = @" select id from city where name = @cityname;";
            int cityId;
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlSelectCity, connection))
                        {
                            sqlCmd.Parameters.Add("@cityname", SqlDbType.Int).Value = "Zilina";
                            cityId = (int)sqlCmd.ExecuteScalar();
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlInsertClient, connection))
                        {
                            sqlCmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = client.FirstName;
                            sqlCmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = client.LastName;
                            sqlCmd.Parameters.Add("@idnumber", SqlDbType.NVarChar).Value = client.IDNumber;
                            sqlCmd.Parameters.Add("@adress", SqlDbType.NVarChar).Value = client.Adress;
                            sqlCmd.Parameters.Add("@city", SqlDbType.Int).Value = cityId;                            
                            if(sqlCmd.ExecuteNonQuery() > 0)
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

        public DataSet FillDataSet(int id)
        {
            string sqlQuery = @"select a.id,FirstName,LastName,CreationDate,IBAN,c.IdNumber from Account as a join Client as c on a.Id_Client = c.id where c.id = @id";
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
                            adapter.Fill(ds, "Account");
                            DataTable dt = ds.Tables["Account"];
                        }
                    }
                    catch(Exception e)
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
