using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sav2 = new Savings2(100);
                sav2.Description = "Greg's Savings2";
                sav2.InterestRate = 0.12m;
                sav2.Print();
                sav2.Deposit(5000);
                sav2.Withdrawal(2000);
                sav2.CalculateAndPayInterest(1);
                sav2.Print();
            } catch (AmountGreaterThanZeroException)
            {
                Console.WriteLine($"Nice try, buster!");
            }

            //var sav1 = new Savings()
            //{
            //    Id = 10,
            //    Description = "My First Savings"
            //};
            //sav1.InterestRate = 0.12m;
            //sav1.Print();
            //sav1.Deposit(5000);
            //sav1.Withdrawal(2000);
            //sav1.CalculateAndPayInterest(1);
            //sav1.Print();

            //var acct1 = new Account()
            //{
            //    Id = 1,
            //    Description = "Test Account"
            //};
            //acct1.Print();
            //acct1.Deposit(9500);
            //acct1.Print();
            //acct1.Withdrawal(6000);
            //acct1.Print();
            //acct1.Withdrawal(4000);
            //acct1.Print();
            //var acct2 = new Account()
            //{
            //    Id = 2,
            //    Description = "New Account"
            //};
            //acct1.Transfer(1500, acct2);
            //acct1.Print();
            //acct2.Print();
            //acct1.Withdrawal(-1000);
            //acct1.Print();
        }
    }
}
