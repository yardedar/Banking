using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class AmountGreaterThanZeroException : Exception
    {
        public decimal CurrentBalance { get; set; }
        public decimal AmountToWithdrawal { get; set; }

        public AmountGreaterThanZeroException(decimal CurrentBalance, decimal AmountToWithdrawal)
            : base()
        {
            this.CurrentBalance = CurrentBalance;
            this.AmountToWithdrawal = AmountToWithdrawal;
        }
        public AmountGreaterThanZeroException() 
            : base() { }

        public AmountGreaterThanZeroException(string Message)
            : base(Message) { }

        public AmountGreaterThanZeroException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
