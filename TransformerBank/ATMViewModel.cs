using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;
using System.Data;

namespace TransformerBank
{
    
    public class ATMViewModel
    {
        CardRepository cardRepository = new CardRepository();
        AccountRepository accountRepository = new AccountRepository();
        TransactionRepository transactionRepository = new TransactionRepository();
        public decimal _ammount;
        public char _type;
        public bool ControlCard(int id, int pin)
        {
            return cardRepository.ControlCard(id, pin);
        }
        public int GetAccountID(int id)
        {
            return cardRepository.GetAccountID(id);
        }
        public string GetAccountAmount(int id)
        {
            return accountRepository.GetAccountAmount(id);
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
        public DataSet FillSource(int id)
        {
            return accountRepository.FillSourceDataSet(id);
        }
    }
}
