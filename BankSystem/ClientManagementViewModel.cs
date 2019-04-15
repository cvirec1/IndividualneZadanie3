using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    
    class ClientManagementViewModel
    {
        ClientRepository clientRepository = new ClientRepository();
        CardRepository cardRepository = new CardRepository();
        TransactionRepository transactionRepository = new TransactionRepository();
        AccountRepository accountRepository = new AccountRepository();
        public DataSet GetAccountsData(int id)
        {
            return clientRepository.FillDataSet(id);
        }
        public DataSet GetCardsData(int id)
        {
            return cardRepository.FillDataSet(id);
        }
        public DataSet GetActiveCardsData(int id)
        {
            return cardRepository.ActiveCard(id);
        }
        public DataSet GetExpiredCardsData(int id)
        {
            return cardRepository.ExpiredCard(id);
        }
        public int GetAccountID(int id)
        {
            return transactionRepository.GetAccountID(id);
        }
        public bool InsertNewCard(int limitCard, int id)
        {
            return cardRepository.InsertCard(limitCard, id);
        }
        public bool CancelSelectedCard(int id)
        {
            return cardRepository.CancelCard(id);
        }
        public bool CloseAccount(int id)
        {
            return accountRepository.CloseAccount(id);
        }
    }
}
