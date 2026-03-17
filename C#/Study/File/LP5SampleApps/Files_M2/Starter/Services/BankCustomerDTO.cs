
using System;

namespace Files_M2;

public class BankCustomerDTO
{
 public string CustomerId { get; set; } = "";
 public string FirstName { get; set; } = "";
 public string LastName { get; set; } = "";
 public List<int> AccountNumbers { get; set; } = new List<int>();

 public static BankCustomerDTO MapToDTO(BankCustomer bankCustomer)
 {
  return new BankCustomerDTO
  {
   CustomerId = bankCustomer.CustomerId,
   FirstName = bankCustomer.FirstName,
   LastName = bankCustomer.LastName,
   AccountNumbers = bankCustomer.Accounts.Select(a => a.AccountNumber).ToList()
  };
 }


 // Constructor used to recover and restore an existing customer from back up
 public BankCustomer(string firstName, string lastName, string customerId, Bank bank)
 {
  // Verify that the CustomerId isn't already in use
  if (bank.GetCustomerById(customerId) == null)
  {
   FirstName = firstName;
   LastName = lastName;
   this.CustomerId = customerId;
   _accounts = new List<IBankAccount>();
  }
  else
  {
   throw new ArgumentException("Customer ID already in use");
  }
 }
}
