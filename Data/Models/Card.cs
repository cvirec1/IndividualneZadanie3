using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Card
    {
        public int ID { get;private set; }
        public int ID_Account { get; set; }
        public int Number { get;private set; }
        public int DailyLimit{ get; set; }
        public DateTime ExpireDate { get;private set; }
    }
}
