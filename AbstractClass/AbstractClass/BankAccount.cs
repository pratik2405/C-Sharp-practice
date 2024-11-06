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

    public abstract class BankAccount
    {
        public abstract string Withdrow(double amt);
        public abstract string Deposit(double amt);
    }
}
