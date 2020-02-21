using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
  public class AccountsManager
  {
    public List<Account> accounts { get; set; } = new List<Account>();

    public static void DisplayAccounts(List<Account> accounts)
    {
      foreach (var account in accounts)
      {
        Console.WriteLine($"You have {account.Amount} in your {account.AccountType}");
      }
    }
    public void Adding(string AccountType, Double Amount)
    {
      var account = accounts.First(accounts => accounts.AccountType == AccountType).Amount;
      account += Amount;
      accounts.First(accounts => accounts.AccountType == AccountType).Amount = account;
    }
    public void Subtracting(string AccountType, Double Amount)
    {
      var account = accounts.First(accounts => accounts.AccountType == AccountType).Amount;
      account -= Amount;
      accounts.First(accounts => accounts.AccountType == AccountType).Amount = account;
    }

  }
}