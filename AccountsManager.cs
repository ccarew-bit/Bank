using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Bank
{
  public class AccountsManager
  {
    public List<Account> accounts { get; set; } = new List<Account>();

    public void LoadAccounts()
    {
      var reader = new StreamReader("accounts.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      accounts = csvReader.GetRecords<Account>().ToList();
    }

    public void SaveAccounts()
    {
      var writer = new StreamWriter("accounts.csv");
      var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
      csvWriter.WriteRecords(accounts);
      writer.Flush();
    }
    public void DisplayAccounts(List<Account> accounts)
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