using System;
using System.Collections.Generic;
using System.Text;

namespace OPPSProject
{
    interface IBankAccount //// Interface
    {
        //Interface members are by default abstract and public
        //only method and properties is define in iinterface
        bool Deposit(decimal amount);// interface method (does not have a body)
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }

    public class SavingAccount : IBankAccount // SavingAccount "implements" the IBankAccount interface
    {
        private decimal _balance;
        private decimal _perDayLimit;
        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else if (_perDayLimit + amount > 5000) //limit is 5000
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0}", amount));

                return true;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
        }

        public override string ToString()
        {
            return String.Format("Saving Account Balance = {0}", _balance);
        }
    }

    public class CurrentAccount : IBankAccount // CurrentAccount "implements" the IBankAccount interface
    {
        private decimal _balance;
        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0}", amount));

                return true;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
        }

        public override string ToString()
        {
            return String.Format("Current Account Balance = {0}", _balance);
        }
    }
    class Interface
    {
        public void Interf()
        {
            IBankAccount savingAccount = new SavingAccount();
            IBankAccount currentAccount = new CurrentAccount();

            savingAccount.Deposit(5005);
            savingAccount.Withdraw(156);
            savingAccount.ToString();

            currentAccount.Deposit(5065);
            currentAccount.Withdraw(600);
            currentAccount.Withdraw(20000);
            currentAccount.ToString();

            Console.ReadLine();
        }
    }
}
