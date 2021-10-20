using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings2
    {
        private Account account { get; set; }

        public int Id => account.Id;
        public decimal Balance => account.Balance;
        public string Description 
        {
            get { return account.Description; }
            set { account.Description = value; }
        }
        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayInterest(int months)
        {
            var interest = this.account.Balance * (InterestRate / 12) * months;
            this.account.Deposit(interest);
            return interest;
        }
        public bool Deposit(decimal amount)
        {
            return this.account.Deposit(amount);
        }
        public bool Withdrawal(decimal amount)
        {
            return this.account.Withdrawal(amount);
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            return this.account.Transfer(amount, ToAccount);
        }
        public void Print()
        {
            this.account.Print();
        }
        
        public Savings2(int id)
        {
            this.account = new Account();
            this.account.Id = Id;
            this.account.Description = "New Savings2";
            
        }
    }
}
