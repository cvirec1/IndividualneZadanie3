using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
namespace BankSystem
{
    class AccountsViewModel
    {
        public AccountRepository accountRepository = new AccountRepository();

        public DataSet GetAccountsData()
        {
            return accountRepository.FillDataSet();
        }

        public DataSet FilterAccountsData(string name, string surname, string number)
        {
            return accountRepository.FilterDataSet(name,surname, number);
        }
    }
}
