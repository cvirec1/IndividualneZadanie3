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
        public DataSet GetAccountsData(int id)
        {
            return clientRepository.FillDataSet(id);
        }
    }
}
