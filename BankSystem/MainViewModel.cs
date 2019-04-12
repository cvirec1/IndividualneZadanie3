using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    class MainViewModel
    {
        public ClientRepository clientRepository = new ClientRepository();
        public bool CheckClient(string idnumber)
        {
            return clientRepository.FindClient(idnumber);
        }
        public int GetID(string idnumber)
        {
            return clientRepository.GetClientID(idnumber);
        }
    }
}
