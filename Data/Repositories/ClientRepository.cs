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
        public int _clientID;
        /// <summary>
        /// Metoda na overenie existencie klienta podla idNUmber.
        /// </summary>
        /// <param name="id">idnumber</param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoda na ziskanie id klienta na zaklade idnumber.
        /// </summary>
        /// <param name="id">idnumber</param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoda na ziskanie dat klienta pre update metodu.
        /// </summary>
        /// <param name="id">id klienta</param>
        /// <returns></returns>
        public List<string> GetClientData(int id)
        {            
            List<string> list = new List<string>();
            string sqlGetClientData = @" select FirstName,LastName,Adress,ci.Name,IdNumber from Client as cl
                                        join City as ci on cl.Id_City=ci.Id where cl.id = @id;";
            try
            {
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlGetClientData, connection))
                        {
                            sqlCmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                            try
                            {
                                using(SqlDataReader reader = sqlCmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        list.Add(reader.GetString(0));
                                        list.Add(reader.GetString(1));
                                        list.Add(reader.GetString(2));
                                        list.Add(reader.GetString(3));
                                        list.Add(reader.GetString(4));
                                    }
                                }
                            }catch(Exception e)
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
        /// Metoda na update udajov klienta.
        /// </summary>
        /// <param name="client">client</param>
        /// <param name="id">id klienta</param>
        /// <returns></returns>
        public bool UpdateClient(Client client,int id)
        {
            string sqlUpdateClient = @" update client set firstname = @name,lastname = @surname,adress=@adress, idnumber=@idnumber, id_city=@city where id = @id;";
            try
            {                
                using (SqlConnection connection = base.CreateConnection())
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlUpdateClient, connection))
                        {
                            sqlCmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = client.FirstName;
                            sqlCmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = client.LastName;
                            sqlCmd.Parameters.Add("@idnumber", SqlDbType.NVarChar).Value = client.IDNumber;
                            sqlCmd.Parameters.Add("@adress", SqlDbType.NVarChar).Value = client.Adress;
                            sqlCmd.Parameters.Add("@city", SqlDbType.Int).Value = client.ID_City;
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
        /// Metoda na vlozenie noveho klienta.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool InsertClient(Client client)
        {
            string sqlInsertClient = @" insert into client (firstname,lastname,Adress,Id_City,IdNumber) output inserted.id values  (@name,@surname,@adress,@city,@idnumber);";
            //string sqlSelectCity = @" select id from city where name = @cityname;";            
            try
            {                
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
                            sqlCmd.Parameters.Add("@city", SqlDbType.Int).Value = client.ID_City;
                            _clientID = (int)sqlCmd.ExecuteScalar();
                            if(_clientID > 0)
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
        /// Metoda na naplnenie dat do gridu.
        /// </summary>
        /// <param name="id">klient id</param>
        /// <returns></returns>
        public DataSet FillDataSet(int id)
        {
            string sqlQuery = @"select a.id,a.id_client,FirstName,LastName,CreationDate,IBAN,c.IdNumber,amount,ActualOverFlow,OverFlowLimit from Account as a join Client as c on a.Id_Client = c.id where c.id = @id";
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
