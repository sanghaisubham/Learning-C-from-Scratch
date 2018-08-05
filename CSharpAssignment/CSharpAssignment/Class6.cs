using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Class6
    {
        static void Main(string[] args)
        {
            Bank bnk = new Bank();
            bnk.Withdraw("123", 100);
            bnk.Withdraw("124", 10000);
            bnk.Deposit("123", 100);
        }
    }
    class BankAccount
    {
        public string Name;
        public float Balance;
        public string AccountNo;
        public static int count=0;
        public static Dictionary<string, int> AccountDict = new Dictionary<string, int>();
        public BankAccount(string name,float balance, string accountno)
        {   
            this.Name = name;
            this.Balance = balance;
            this.AccountNo = accountno;
            AccountDict[accountno] = count;
            count++;
        }
        public void Show()
        {
            Console.WriteLine("Name :: {0}", this.Name);
            Console.WriteLine("Balance :: {0}", this.Balance);
            Console.WriteLine("Account No :: {0}\n", this.AccountNo);
        }

    }
    class Bank
    {
        private List<BankAccount> Accounts;
        
        public Bank()
        {
            Accounts = new List<BankAccount>();
            Accounts.Add(new BankAccount("A1", 1000, "123"));
            Accounts.Add(new BankAccount("A2", 1001, "124"));
            Accounts.Add(new BankAccount("A3", 1002, "125"));
            Accounts.Add(new BankAccount("A4", 1003, "126"));
            Accounts.Add(new BankAccount("A5", 1004, "127"));
        }
        public bool VerifyAccount(string AccountNo)
        {
            foreach(BankAccount acc in this.Accounts)
            {
                if (acc.AccountNo == AccountNo)
                    return true;
            }
            return false;
        }
        public bool VerifyBalance(string AccountNo, float amt)
        {
            int ind = BankAccount.AccountDict[AccountNo];
            float balance = this.Accounts[ind].Balance;
            if (balance < amt)
                return false;
            return true;

        }
        public void Withdraw(string AccountNo, float amount)
        {
            if(VerifyBalance(AccountNo, amount))
            {
                int ind = BankAccount.AccountDict[AccountNo];
                this.Accounts[ind].Balance -= amount;
                this.Accounts[ind].Show();
            }
            else
            {
                Console.WriteLine("Insufficient balance\n");
            }
            
        }
        public void Deposit(string AccountNo, float amount)
        {
            int ind = BankAccount.AccountDict[AccountNo];
            this.Accounts[ind].Balance += amount;
            this.Accounts[ind].Show();
        }
    }
}
