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

      var accounts = new List<Account>();

      var reader = new StreamReader("accounts.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      accounts = csvReader.GetRecords<Account>().ToList();

      var isRunning = true;
      while (isRunning)
      {
        foreach (var Account in accounts)
        {
          Console.WriteLine($"Your current checking balance:{Account.Checking}");
          Console.WriteLine($"Your current savings balance:{Account.Saving}");
        }


        Console.WriteLine("would you like to (A)dd (W)ithdraw (T)ransfer or (Q)uit?");
        var input = Console.ReadLine().ToLower();

        if (input == "a")
        {
          Console.WriteLine("which account would you like to add to? (C)hecking or (S)avings. ");
          var add = Console.ReadLine().ToLower();
          if (add == "c")
          {

          }
          else if (add == "s")
          {

          }
        }
        else if (input == "w")
        {
          Console.WriteLine("which account would you like to withdraw from? (C)hecking or (S)avings. ");
          var withdraw = Console.ReadLine().ToLower();
          if (withdraw == "c")
          {

          }
          else if (withdraw == "s")
          {

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