using System.Globalization;
using Bank.Entities.Exceptions;

namespace Bank.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(){

        }

        public Account(int number, string holder, double balance, double withdrawlimit){
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;    
        }

        public void Deposit(double amount){
            Balance += amount;
        }

        public void Withdraw(double amount){
            
            if (amount > WithdrawLimit){
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (amount > Balance){
                throw new DomainExceptions("Not enough balance");
            }
            
            Balance -= amount;
        }

        override public string ToString(){

            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}