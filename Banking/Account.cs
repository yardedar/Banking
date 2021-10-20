using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        public bool Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
            }
            this.Balance = this.Balance + amount;
            return true;
        }
        public bool Withdrawal(decimal amount)
        {
            if(amount > this.Balance)
            {
                throw new AmountGreaterThanZeroException();
            }
            if(amount <= 0)
            {
                throw new AmountGreaterThanZeroException(this.Balance, amount);
            }
            this.Balance = this.Balance - amount;
            return true;
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            var success = Withdrawal(amount);
            if(success == true)
            {
                ToAccount.Deposit(amount);
            }
            return true;
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
