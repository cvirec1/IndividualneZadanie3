using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    class AccountViewModel
    {
        public string _idNumber;
        public int _idCity;
        public string _firstName;
        public string _lastName;
        public string _adress;
        ClientRepository clientRepository = new ClientRepository();
        CityRepository cityRepository = new CityRepository();

        public bool InsertClient()
        {
            Client client = new Client();
            client.IDNumber = _idNumber;
            client.ID_City = _idCity;
            client.FirstName = _firstName;
            client.LastName = _lastName;
            client.Adress = _adress;
            return clientRepository.InsertClient(client);
        }
        public DataSet FillComboBoxCity()
        {
            return cityRepository.FillDataSet();
        }

    }
}
