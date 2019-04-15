using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    class MainViewModel
    {
        public ClientRepository clientRepository = new ClientRepository();
        AccountRepository accountRepository = new AccountRepository();
        public bool CheckClient(string idnumber)
        {
            return clientRepository.FindClient(idnumber);
        }
        public int GetID(string idnumber)
        {
            return clientRepository.GetClientID(idnumber);
        }
        public DataSet ViewBankData()
        {
            return accountRepository.ViewBankData();
        }
        public DataSet ViewTopAccount()
        {
            return accountRepository.ViewTopAccount();
        }
        public DataSet ViewAccountCount()
        {
            return accountRepository.ViewAccountCount();
        }
    }
}
