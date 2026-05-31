using Files_M2;

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Demonstrate JSON file storage and retrieval using BankCustomer, BankAccount, and Transaction classes");

        // Create a Bank object
        Bank bank = new Bank();

        // Create a bank customer named Niki Demetriou
        string firstName = "Niki";
        string lastName = "Demetriou";
        BankCustomer customer = new BankCustomer(firstName, lastName);

        // Add Checking, Savings, and MoneyMarket accounts to bankCustomer
        bankCustomer.AddAccount(new CheckingAccount(BankCustomer, BankCustomer.CustomerId, 5000));
        bankCustomer.AddAccount(new SavingsAccount(bankCustomer, bankCustomer.CustomerId, 15000));
        bankCustomer.AddAccount(new MoneyMarketAccount(bankCustomer, bankCustomer.CustomerId, 90000));

        // Add the bank customer to the bank object
        bank.AddCustomer(bankCustomer);

        // Simulate one month of transactions for customer Niki Demetriou

    }
}