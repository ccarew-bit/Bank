using System;
using System.Collections.Generic;

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
    public void Adding(string AccountType, int Amount)
    {

    }
  }
}