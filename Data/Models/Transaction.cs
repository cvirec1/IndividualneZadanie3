using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Transaction
    {
        public int ID { get; private set; }
        public decimal Amount { get;private set; }
        public DateTime CreationDate { get;private set; }
        public DateTime ExecuteDate { get;private set; }
        public int VS { get; set; }
        public int SS { get; set; }
        public int KS { get; set; }        
    }
}
