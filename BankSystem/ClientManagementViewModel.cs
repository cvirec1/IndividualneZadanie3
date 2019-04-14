﻿using System;
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
        public DataSet GetAccountsData(int id)
        {
            return clientRepository.FillDataSet(id);
        }
        public DataSet GetCardsData(int id)
        {
            return cardRepository.FillDataSet(id);
        }
        public int GetAccountID(int id)
        {
            return transactionRepository.GetAccountID(id);
        }
    }
}