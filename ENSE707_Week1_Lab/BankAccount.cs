using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSE707_Week1_Lab
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }
        public BankAccount(string accountHolder, decimal openingBalance)
        {
            AccountHolder = accountHolder;
            Balance = openingBalance;
        }
        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            if (amount < 0)
            {
                throw new InvalidOperationException("Deposit amount cannot be negative.");
            }
        }
        public bool Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException("Withdrawal amount cannot be negative.");
            }
            if (amount > Balance)
            {
                Console.WriteLine("Cannot withdraw more than the current balance.");
                return false;
            }
            else
            {
                Balance = Balance - amount;
                return true;
            }
        }
        public decimal CalculateTransationFee(decimal amount)
        {
            return amount * 0.02m;
        }
    }
}
