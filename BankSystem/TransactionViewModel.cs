using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;

namespace BankSystem
{
    public class TransactionViewModel
    {
        TransactionRepository transactionRepository = new TransactionRepository();
        AccountRepository accountRepository = new AccountRepository();
        public decimal _ammount;
        public char _type;
        public DataSet FillDestination(int id)
        {
            return accountRepository.FillDestinationDataSet(id);
        }
        public DataSet FillSource(int id)
        {
            return accountRepository.FillSourceDataSet(id);
        }
        public bool InsertTransaction(int id)
        {
            Transaction transaction = new Transaction();
            transaction.Amount = _ammount;
            transaction.TransacitonType = _type;
            return transactionRepository.InsertTransaction(transaction, id);            
        }
    }
}
