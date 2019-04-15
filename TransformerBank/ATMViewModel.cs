using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;

namespace TransformerBank
{
    
    public class ATMViewModel
    {
        CardRepository cardRepository = new CardRepository();
        AccountRepository accountRepository = new AccountRepository();
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
    }
}
