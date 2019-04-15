using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Account
    {
        public int ID { get;private set; }
        public int ID_Client { get; set; }
        public int ID_Bank { get; set; }
        public DateTime CreationDate { get;private set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get;  set; }
        public string IBAN { get;set; }
        public decimal ActualOverFlow { get; set; }
        public decimal OverFlowLimit { get; set; }
    }
}
