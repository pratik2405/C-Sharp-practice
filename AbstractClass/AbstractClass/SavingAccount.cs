using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //1. Write a C# program to create an abstract class BankAccount with abstract methods deposit() and withdraw().
    //Create subclasses: SavingsAccount and CurrentAccount that inherit the BankAccount class
    //and implement the respective methods to handle deposits and withdrawals for each account type.
    public class SavingAccount : BankAccount
    {
        private int accno;
        private string name;
        private double bal;

        public SavingAccount(int accno, string name, double bal)
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
            else
            {
                bal = bal = amt;
                return $"Withdrow Successfull{amt} & Current bal={bal} ";
            }
        }

        public override string ToString()
        {
            return $"Acc NO={accno} / Name={name} / Balance={bal}";
        }
    }
}
