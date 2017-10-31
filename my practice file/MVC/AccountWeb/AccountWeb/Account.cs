using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace AccountWeb
{
    [Serializable]
    public class Account
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        private decimal balance;

        public string Deposited(decimal amount)
        {
            balance += amount;
            return "deposited";
        }

        public string withdrow(decimal amount)
        {
            if (amount < 0)
            {
                return "Negative amount are not allowed";
            }
            else if(balance<amount)
            {
                return "you do not have sufficent balance";
            }
            balance -= amount;
            return "Withdorow completd";

        }

        public string reportshow()
        {
            return AccountName +" "+ "AccountNumber" + AccountNumber +" "+ "Balance" + balance + "taka";
        }
    }
}