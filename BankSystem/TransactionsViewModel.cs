using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    public class TransactionsViewModel
    {
        TransactionRepository transactionRepository = new TransactionRepository();
        public DataSet GetAccountsTransactionsData(int id)
        {
            return transactionRepository.FillAccountDataSet(id);
        }
        public DataSet GetTransactionsData()
        {
            return transactionRepository.FillDataSet();
        }
    }
}
