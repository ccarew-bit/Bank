using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Bank
{
  class Program
  {
    static void SaveAccounts(List<Account> accounts)
    {
      var writer = new StreamWriter("accounts.csv");
      var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
      csvWriter.WriteRecords(accounts);
      writer.Flush();
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to First Bank of Suncoast!");
      var accountsManager = new AccountsManager();
      var accounts = new List<Account>();
      // accounts.Add(new Account { AccountType = "Checking", Amount = 0 });
      // accounts.Add(new Account { AccountType = "Savings", Amount = 0 });

      var reader = new StreamReader("accounts.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      accounts = csvReader.GetRecords<Account>().ToList();

      AccountsManager.DisplayAccounts(accounts);

      var isRunning = true;
      while (isRunning)
      {
        Console.WriteLine("would you like to (A)dd (W)ithdraw (T)ransfer or (Q)uit?");
        var input = Console.ReadLine().ToLower();

        if (input == "a")
        {
          Console.WriteLine("which account would you like to add to? (C)hecking or (S)avings. ");
          var add = Console.ReadLine().ToLower();
          if (add == "c")
          {
            Console.WriteLine("how much would you like to deposit into your checking account?");
            var deposit = double.Parse(Console.ReadLine());
            accountsManager.Adding("Checking", deposit);
            SaveAccounts(accounts);
          }
          else if (add == "s")
          {
            Console.WriteLine("how much would you like to deposit into your savings account?");
            var deposit = double.Parse(Console.ReadLine());
            accountsManager.Adding("Savings", deposit);
            SaveAccounts(accounts);
          }
        }
        else if (input == "w")
        {
          Console.WriteLine("which account would you like to withdraw from? (C)hecking or (S)avings. ");
          var withdraw = Console.ReadLine().ToLower();
          if (withdraw == "c")
          {
            Console.WriteLine("how much would you like to withdraw from your checking account?");
            var deposit = double.Parse(Console.ReadLine());
            accountsManager.Subtracting("Checking", deposit);
            SaveAccounts(accounts);
          }
          else if (withdraw == "s")
          {
            Console.WriteLine("how much would you like to withdraw from your savings account?");
            var deposit = double.Parse(Console.ReadLine());
            accountsManager.Subtracting("Savings", deposit);
            SaveAccounts(accounts);
          }
        }
        else if (input == "t")
        {
          Console.WriteLine("which account would you like to transfer to? (C)hecking or (S)avings. ");
          var transfer = Console.ReadLine().ToLower();
          if (transfer == "c")
          {

          }
          else if (transfer == "s")
          {

          }
        }
        else if (input == "q")
        {
          isRunning = false;
        }

      }
    }
  }
}