using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_define_with_account_transaction
{
    class account
    {
        public string number;
        public string name;
        public double balance;

        public string diposite(double ammount)
        {
            balance += ammount;
            return ammount + " Taka has diposite";
        }

        public string withdrew(double amount)
        {
            if (balance - amount>0)
            {
                balance -= amount;
                return amount + "Taka Withdrew";
            }
            else
            {
                return "No suficent Balance";
            }
            
        }
    }
    
}
