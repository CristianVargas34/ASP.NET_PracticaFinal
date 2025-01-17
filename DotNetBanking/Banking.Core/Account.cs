﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Core
{
    public class Account
    {
        public int AccountID { get; set; }
        public string NO_Account { get; set; }
        public double Amount { get; set; }
        public DateTime DateCreate { get; set; }

        public string UserID { get; set; }

        //TODO:CREATE RELATION WITH CUSTOMER
        public virtual ICollection<Transaction> transactions { get; set; }

    }
}