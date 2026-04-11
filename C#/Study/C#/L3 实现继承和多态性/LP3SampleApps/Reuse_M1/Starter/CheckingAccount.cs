
using System;

namespace Reuse_M1;

public class CheckingAccount : BankAccount
{
 public CheckingAccount(string CustomerId, double initialBalance) : base(CustomerId, initialBalance, "Checking")
 {

 }

 // public static properties with private setters for default overdraft limit and default interest rate
 public static double DefaultInterestRate { get; private set; }

 // public property for overdraft limit
 public static double DefaultOverdraftLimit { get; private set; }
 public double OverdraftLimit { get; set; }

 static CheckingAccount()
 {

  DefaultOverdraftLimit = 500; // Set the default overdraft limit
                               // Default interest rate for checking accounts is already set in the BankAccount static constructor

  DefaultInterestRate = 0.00; // Set the default interest rate for checking accounts

 }

 public CheckingAccount(string customerIdNumber, double balance = 200, double overdraftLimit = 500)
 : base(customerIdNumber, balance, "Checking")
 {
  OverdraftLimit = overdraftLimit;
 }

 public override string DisplayAccountInfo()
 {
       return base.DisplayAccountInfo() + $", Overdraft Limit: {OverdraftLimit}";
 }

 public override bool Withdraw(double amount)
 {
  if (amount > 0 && Balance + OverdraftLimit >= amount)
  {
   Balance -= amount;

   // Check if the account is overdrawn
   if (Balance < 0)
   {
    double overdraftFee = AccountCalculations.CalculateOverdraftFee(Math.Abs(Balance), BankAccount.OverdraftRate, BankAccount.MaxOverdraftFee);
    Balance -= overdraftFee;
    Console.WriteLine($"Overdraft fee of ${overdraftFee} applied.");
   }

   return true;
  }
  return false;
 }


}

