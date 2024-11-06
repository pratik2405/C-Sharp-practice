using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class CurrentAccount:BankAccount
    {
        private int accno;
        private string name;
        private double bal;

        public CurrentAccount(int accno, string name, double bal)
        {
            this.accno = accno;
            this.name = name;
            this.bal = bal;
        }

        public override string Deposit(double amt)
        {
            bal = bal + amt;
            return $"Deposite successfull={amt} & Current bal={bal}";
        }

        public override string Withdrow(double amt)
        {
            if (amt > bal)
            {
                return $"Low Balance !";
            }
            else if(bal-amt <1000)
            {
                return $"minimum bal 1000 require !";
            }
            else 
            {
                bal = bal - amt;
                return $"Withdrow Successfull={amt} & Current bal={bal} ";
            }
        }

        public override string ToString()
        {
            return $"Acc NO={accno} / Name={name} / Balance={bal}";
        }
    }
}
