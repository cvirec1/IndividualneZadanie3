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
        public int _vs;
        public int _ss;
        public int _ks;
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
        public bool UpdateAmount(int id)
        {
            return accountRepository.UpdateAccountAmount(id);
        }
        public bool UpdateSourceAmount(int id)
        {
            return accountRepository.UpdateSourceAccountAmount(id);
        }
        public bool UpdateDestinationAmount(int id)
        {
            return accountRepository.UpdateDestinationAccountAmount(id);
        }
    }
}
