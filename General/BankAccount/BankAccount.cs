using System;

namespace BankAccount
{
    public class Account
    {
    private decimal balance;

    public void Deposit(decimal amount)
    {
      balance += amount;
    }

    public void Withdraw(decimal amount)
    {
      balance -= amount;
    }

    public void TransferFunds(Account destination, decimal amount)
    {
        if (this.balance > amount){
            this.balance -= amount;
            destination.balance += amount; 
    }}

    public decimal Balance
    {
      get { return balance; }
      //set { balance = value; }
    }
  }
}
