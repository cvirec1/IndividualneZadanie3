using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    class AccountViewModel
    {
        public string _idNumber;
        public int _idCity;
        public string _firstName;
        public string _lastName;
        public string _adress;
        public int _id_client;
        public int _id_bank = 7;
        public decimal _amount;
        public string _iban;
        public decimal _overFlow;
        
        ClientRepository clientRepository = new ClientRepository();
        CityRepository cityRepository = new CityRepository();
        AccountRepository accountRepository = new AccountRepository();

        public bool InsertClient()
        {
            Client client = new Client();
            client.IDNumber = _idNumber;
            client.ID_City = _idCity;
            client.FirstName = _firstName;
            client.LastName = _lastName;
            client.Adress = _adress;
            return clientRepository.InsertClient(client);
        }
        public bool UpdateClient(int clientID)
        {
            Client client = new Client();
            client.IDNumber = _idNumber;
            client.ID_City = _idCity;
            client.FirstName = _firstName;
            client.LastName = _lastName;
            client.Adress = _adress;
            return clientRepository.UpdateClient(client,clientID);
        }
        public List<string> GetClientData(int id)
        {
            List<string> list = clientRepository.GetClientData(id);
            return list;
            
        }
        public List<string> GetAccountData(int id)
        {
            List<string> list = accountRepository.GetAccountData(id);
            return list;
        }
        public bool InsertAccount()
        {
            Account account = new Account();
            account.ID_Client = _id_client;
            account.ID_Bank = _id_bank;
            account.Amount = _amount;
            account.IBAN = _iban;
            account.OverFlowLimit = _overFlow;
            return accountRepository.InsertAccount(account);
        }
        public bool UpdateAccount(int accountID)
        {
            Account account = new Account();
            account.Amount = _amount;            
            account.OverFlowLimit = _overFlow;
            return accountRepository.UpdateAccount(account, accountID);
            
        }
        public DataSet FillComboBoxCity()
        {
            return cityRepository.FillDataSet();
        }
        public string GetIBAN()
        {
            return accountRepository.GenerateIBAN();
        }

        public int GetCityID(string text)
        {
            return cityRepository.GetCityID(text);            
        }
        public int GetInsertedClientID()
        {
            return clientRepository._clientID;
        }
        public int GetInsertedAccountID()
        {
            return accountRepository._accountID;
        }

    }
}
