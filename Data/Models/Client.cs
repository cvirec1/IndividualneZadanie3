﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Client
    {
        public int ID { get;private set; }
        public string IDNumber { get; set; }
        public int ID_City { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }        
    }
}
