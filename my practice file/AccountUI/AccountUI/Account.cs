using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountUI
{
    [Serializable]
    class Account
    {
        public string customerName;
        public string AccountNo;
        private Decimal balance;

        public string DepositAmount(Decimal Amount)
        {
            balance += Amount;
            return "Depositet";

        }

        public string withdraw(decimal Amount)
        {
            balance -= Amount;
            return "withdraw";
        }

        public string GetInfo()
        {
            return "AccountNO" + AccountNo + "your balance is" + balance;
        }
    }
}
